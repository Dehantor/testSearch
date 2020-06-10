namespace testSearch
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.labelDir = new System.Windows.Forms.Label();
            this.labelMask = new System.Windows.Forms.Label();
            this.labelNabor = new System.Windows.Forms.Label();
            this.textBoxDir = new System.Windows.Forms.TextBox();
            this.textBoxNabor = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonReview = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.labelFile = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.labeldelegate = new System.Windows.Forms.Label();
            this.buttonPause = new System.Windows.Forms.Button();
            this.textBoxMask = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Location = new System.Drawing.Point(205, 36);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(583, 374);
            this.treeView1.TabIndex = 0;
            // 
            // labelDir
            // 
            this.labelDir.AutoSize = true;
            this.labelDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDir.Location = new System.Drawing.Point(19, 8);
            this.labelDir.Name = "labelDir";
            this.labelDir.Size = new System.Drawing.Size(65, 18);
            this.labelDir.TabIndex = 1;
            this.labelDir.Text = "Каталог";
            // 
            // labelMask
            // 
            this.labelMask.AutoSize = true;
            this.labelMask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMask.Location = new System.Drawing.Point(20, 46);
            this.labelMask.Name = "labelMask";
            this.labelMask.Size = new System.Drawing.Size(53, 18);
            this.labelMask.TabIndex = 2;
            this.labelMask.Text = "Маска";
            // 
            // labelNabor
            // 
            this.labelNabor.AutoSize = true;
            this.labelNabor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNabor.Location = new System.Drawing.Point(20, 108);
            this.labelNabor.Name = "labelNabor";
            this.labelNabor.Size = new System.Drawing.Size(127, 18);
            this.labelNabor.TabIndex = 3;
            this.labelNabor.Text = "Набор символов";
            // 
            // textBoxDir
            // 
            this.textBoxDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDir.Location = new System.Drawing.Point(98, 8);
            this.textBoxDir.Name = "textBoxDir";
            this.textBoxDir.Size = new System.Drawing.Size(651, 22);
            this.textBoxDir.TabIndex = 4;
            // 
            // textBoxNabor
            // 
            this.textBoxNabor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNabor.Location = new System.Drawing.Point(23, 129);
            this.textBoxNabor.Name = "textBoxNabor";
            this.textBoxNabor.Size = new System.Drawing.Size(160, 24);
            this.textBoxNabor.TabIndex = 6;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Location = new System.Drawing.Point(35, 171);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(131, 38);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // buttonReview
            // 
            this.buttonReview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReview.Location = new System.Drawing.Point(739, 6);
            this.buttonReview.Name = "buttonReview";
            this.buttonReview.Size = new System.Drawing.Size(49, 28);
            this.buttonReview.TabIndex = 8;
            this.buttonReview.Text = "...";
            this.buttonReview.UseVisualStyleBackColor = true;
            this.buttonReview.Click += new System.EventHandler(this.ButtonReview_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(42, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Время поиска";
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimer.Location = new System.Drawing.Point(67, 278);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(44, 18);
            this.labelTimer.TabIndex = 11;
            this.labelTimer.Text = "00:00";
            // 
            // labelFile
            // 
            this.labelFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFile.AutoSize = true;
            this.labelFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFile.Location = new System.Drawing.Point(65, 416);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(0, 18);
            this.labelFile.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Обрабатывается файл";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "обработанных файлов";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(42, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Количество ";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount.Location = new System.Drawing.Point(82, 361);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(16, 18);
            this.labelCount.TabIndex = 16;
            this.labelCount.Text = "0";
            // 
            // labeldelegate
            // 
            this.labeldelegate.AutoSize = true;
            this.labeldelegate.Location = new System.Drawing.Point(741, 421);
            this.labeldelegate.Name = "labeldelegate";
            this.labeldelegate.Size = new System.Drawing.Size(0, 17);
            this.labeldelegate.TabIndex = 17;
            // 
            // buttonPause
            // 
            this.buttonPause.Enabled = false;
            this.buttonPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPause.Location = new System.Drawing.Point(37, 219);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(129, 38);
            this.buttonPause.TabIndex = 18;
            this.buttonPause.Text = "Пауза";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.ButtonPause_Click);
            // 
            // textBoxMask
            // 
            this.textBoxMask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMask.Location = new System.Drawing.Point(22, 72);
            this.textBoxMask.Name = "textBoxMask";
            this.textBoxMask.Size = new System.Drawing.Size(100, 27);
            this.textBoxMask.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxMask);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.labeldelegate);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonReview);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxNabor);
            this.Controls.Add(this.textBoxDir);
            this.Controls.Add(this.labelNabor);
            this.Controls.Add(this.labelMask);
            this.Controls.Add(this.labelDir);
            this.Controls.Add(this.treeView1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Search";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label labelDir;
        private System.Windows.Forms.Label labelMask;
        private System.Windows.Forms.Label labelNabor;
        private System.Windows.Forms.TextBox textBoxDir;
        private System.Windows.Forms.TextBox textBoxNabor;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonReview;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labeldelegate;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.TextBox textBoxMask;
    }
}

