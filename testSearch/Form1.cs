using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testSearch
{
    public partial class Form1 : Form
    {
        static string dir = @"c:\"; //папка для поиска
        string fileMask = "*.*"; //маска
        TreeNode root = new TreeNode(dir); //корень поиска
        //таймер
        int hour = 0;
        int moment = 0;
        int second = 0;
        //Поиск?
        bool isSearch = false;
        bool isPause = false;
        bool isStop = false;
        //количество файлов
        int fileCountFound = 0;
        int fileCountProcess = 0;

        //для очистки Task
        CancellationTokenSource cts;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {


            //первоночаные значения
            Control.CheckForIllegalCrossThreadCalls = false;
            treeView1.Nodes.Clear();
            fileCountFound = 0;
            fileCountProcess = 0;
            hour = 0;
            moment = 0;
            second = 0;
            isSearch = false;
            isPause = false;
            //логирование
            File.WriteAllText("log.txt", "");
            //минимальное значение окна
            this.MinimumSize = new Size(400, 400);
            //работа с реестром
            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey project = currentUserKey.OpenSubKey("testSearch");
            //при первом запуске программы, создаются ключи вреестре
            if (project == null) 
            {
                RegistryKey testSearch = currentUserKey.CreateSubKey("testSearch");
                testSearch.SetValue("startDir", @"c:\");
                textBoxDir.Text = @"c:\";
                testSearch.SetValue("fileMask", @"*.*");
                textBoxMask.Text = @"*.*";
                testSearch.SetValue("nabor", @"");
                textBoxNabor.Text = "";

            }
            //считываются критерии с реестра                      
            else
            {
                RegistryKey testSearch = currentUserKey.CreateSubKey("testSearch");
                textBoxDir.Text = testSearch.GetValue("startDir").ToString();
                textBoxMask.Text = testSearch.GetValue("fileMask").ToString();
                textBoxNabor.Text = testSearch.GetValue("nabor").ToString();
                testSearch.Close();

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //сохранение критериев
            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey testSearch = currentUserKey.CreateSubKey("testSearch");
            testSearch.SetValue("startDir", textBoxDir.Text);
            testSearch.SetValue("fileMask", textBoxMask.Text);
            testSearch.SetValue("nabor", textBoxNabor.Text);
        }

        private void ButtonReview_Click(object sender, EventArgs e)
        {
            //isStop = true;
            FolderBrowserDialog openDir = new FolderBrowserDialog();
            openDir.ShowNewFolderButton = false;
            if (openDir.ShowDialog() == DialogResult.OK)
            {
                textBoxDir.Text = openDir.SelectedPath;
            }
            //treeView1.Nodes.Clear();
        }

        //Алготим поиска
        public async void treeSearch(TreeNode treeRoot)
        {
            
            cts = new CancellationTokenSource();//для мусора
            if (!isStop)//если не стоп
            { 
                string pathRoot;
                try
                {
                    pathRoot = treeRoot.FullPath;//берем путь в дереве
                }
                catch {
                    return;
                }
                DirectoryInfo dirInfo = new DirectoryInfo(pathRoot);
                DirectoryInfo[] arrayDirInfo;

                try
                {
                    arrayDirInfo = dirInfo.GetDirectories(); //смотрим новые директории в папке
                }
                catch
                {
                    return;
                }
                if (arrayDirInfo.Length != 0)
                    foreach (DirectoryInfo currentDirectory in arrayDirInfo)//каждую папку добавляем в дерево
                    {
                        TreeNode curDir = new TreeNode(currentDirectory.Name);
                        while (isPause)
                        {
                            await Task.Delay(100);
                        }
                        cts = new CancellationTokenSource();
                        if (!isStop) Invoke(new Action(() => treeRoot.Nodes.Add(curDir))); else return;
                        if (cts.Token.IsCancellationRequested) return;
                        await Task.Delay(2000);
                        cts.Dispose();
                        cts = null;
                        treeSearch(curDir);
                    }
                FileInfo[] arrayFileInfo;
                try
                {
                    arrayFileInfo = dirInfo.GetFiles(textBoxMask.Text);//проверяем наличие файлов по маске
                }
                catch
                {
                    return;
                }
                if (arrayFileInfo.Length != 0)
                    foreach (FileInfo currentFile in arrayFileInfo) //файл удовлетворяющий критериям поиска добавляем в дерево
                    {
                        await Task.Delay(200);
                        fileCountFound++;
                        labelFile.Text = currentFile.Name;
                        while (isPause)
                        {
                            await Task.Delay(100);
                        }
                        if (currentFile.Length < 25000000)
                            if (await scanDocument(currentFile))
                            {
                                if (!isStop) treeRoot.Nodes.Add(currentFile.Name);
                                else return;
                            };
                    }
            }
            else return;
        }
        //метод поиска символов в файле
        public async Task<bool> scanDocument(FileInfo currentFile)
        {
            cts = new CancellationTokenSource();
            return await Task.Run(() =>
            {
                string tmp = File.ReadAllText(currentFile.FullName);
                try
                {
                    if (tmp.IndexOf(textBoxNabor.Text, StringComparison.CurrentCulture) != -1)
                    {
                        return true;
                    }
                   
                }
                catch
                {
                }

                fileCountProcess++;
                labelCount.Text = fileCountProcess.ToString();
                return false;
            });

        }
        //запуск поиска
        private async void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (validMask() && validDir())//валидация
            {
                cts?.Cancel();//если новый поиск всё старое отметаем
                isStop = true;
                await Task.Delay(2000);
                //первоночаные значения 
                isStop = false;
                fileCountFound = 0;
                fileCountProcess = 0;
                hour = 0;
                moment = 0;
                second = 0;
                isSearch = true;
                isPause = false;
                fileCountFound = 0;
                labelCount.Text = "0";
                labelFile.Text = "";
                buttonPause.Enabled = true;
                buttonPause.Text = "Пауза";
                treeView1.Nodes.Clear();
                timer1.Start();
                cts = new CancellationTokenSource();
                try
                {
                    TreeNode tree = new TreeNode(textBoxDir.Text);
                    treeView1.Nodes.Add(tree);
                    treeSearch(tree);
                }
                catch(Exception er)
                {
                    MessageBox.Show(er.Message);
                }
            }

        }
        //счетчик времени
        private void Timer1_Tick(object sender, EventArgs e)
        {
            second++;
            if (second >= 60)
            {
                second = 0;
                moment++;
                if (moment >= 60)
                {
                    moment = 0;
                    hour++;
                }
            }
            if (hour == 0)
                labelTimer.Text = moment + ":" + second;
            else
                labelTimer.Text = hour+":"+moment + ":" + second;
        }
        //валидация маски
        public bool validMask()
        {
            string[] m=textBoxMask.Text.Split('.');
            if (m.Length == 2 && m[0].Length > 0 && m[1].Length >= 0)
                return true;
            else
            {
                MessageBox.Show("Введите корректную маску");
                return false;
            }

        }
        //валидация директории
        public bool validDir()
        {
            if(Directory.Exists(textBoxDir.Text))
            { return true; }
            else
            {
                MessageBox.Show("Укажите корректную директорию");
                return false;
            }
        } 
        //Пауза
        private void ButtonPause_Click(object sender, EventArgs e)
        {
            isPause = !isPause;
            if (isPause)
            {
                timer1.Stop();
                buttonPause.Text = "Продолжить";
            }
            else
            {
                timer1.Start();
                buttonPause.Text = "Пауза";
            }
        }
    }
}