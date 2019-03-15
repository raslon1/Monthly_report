namespace Monthly_report
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.file_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.load_files_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.close_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.add_companies = new System.Windows.Forms.ToolStripMenuItem();
            this.шаблоныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lv = new System.Windows.Forms.ListView();
            this.cH1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cH2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cH3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cH4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cH5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cH6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.school_b_rb = new System.Windows.Forms.RadioButton();
            this.ds_b_rb = new System.Windows.Forms.RadioButton();
            this.school_a_rb = new System.Windows.Forms.RadioButton();
            this.ds_a_rb = new System.Windows.Forms.RadioButton();
            this.rb_201_301 = new System.Windows.Forms.RadioButton();
            this.rb_211_311 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pdo_a_rb = new System.Windows.Forms.RadioButton();
            this.pdo_b_rb = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.backWorker = new System.ComponentModel.BackgroundWorker();
            this.menu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_menu,
            this.settingsmenu});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(931, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // file_menu
            // 
            this.file_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.load_files_menu,
            this.close_menu});
            this.file_menu.Name = "file_menu";
            this.file_menu.Size = new System.Drawing.Size(48, 20);
            this.file_menu.Text = "Файл";
            // 
            // load_files_menu
            // 
            this.load_files_menu.Name = "load_files_menu";
            this.load_files_menu.Size = new System.Drawing.Size(169, 22);
            this.load_files_menu.Text = "Загрузить файлы";
            this.load_files_menu.Click += new System.EventHandler(this.load_files_menu_Click);
            // 
            // close_menu
            // 
            this.close_menu.Name = "close_menu";
            this.close_menu.Size = new System.Drawing.Size(169, 22);
            this.close_menu.Text = "Выход";
            this.close_menu.Click += new System.EventHandler(this.close_menu_Click);
            // 
            // settingsmenu
            // 
            this.settingsmenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_companies,
            this.шаблоныToolStripMenuItem});
            this.settingsmenu.Name = "settingsmenu";
            this.settingsmenu.Size = new System.Drawing.Size(79, 20);
            this.settingsmenu.Text = "Настройки";
            // 
            // add_companies
            // 
            this.add_companies.Name = "add_companies";
            this.add_companies.Size = new System.Drawing.Size(196, 22);
            this.add_companies.Text = "Добавить учреждения";
            this.add_companies.Click += new System.EventHandler(this.add_companies_Click);
            // 
            // шаблоныToolStripMenuItem
            // 
            this.шаблоныToolStripMenuItem.Name = "шаблоныToolStripMenuItem";
            this.шаблоныToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.шаблоныToolStripMenuItem.Text = "Шаблоны";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(443, 609);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Отчет";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(443, 634);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(443, 660);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lv
            // 
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cH1,
            this.cH2,
            this.cH3,
            this.cH4,
            this.cH5,
            this.cH6});
            this.lv.FullRowSelect = true;
            this.lv.Location = new System.Drawing.Point(12, 27);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(907, 563);
            this.lv.TabIndex = 17;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            this.lv.SelectedIndexChanged += new System.EventHandler(this.lv_SelectedIndexChanged);
            // 
            // cH1
            // 
            this.cH1.Text = "Название учреждения";
            this.cH1.Width = 200;
            // 
            // cH2
            // 
            this.cH2.Text = "Номер лицевого счета";
            this.cH2.Width = 130;
            // 
            // cH3
            // 
            this.cH3.Text = "Номер лицевого счета";
            this.cH3.Width = 130;
            // 
            // cH4
            // 
            this.cH4.Text = "Тип учреждения";
            this.cH4.Width = 100;
            // 
            // cH5
            // 
            this.cH5.Text = "Школа/Детский сад";
            this.cH5.Width = 120;
            // 
            // cH6
            // 
            this.cH6.Text = "Файл";
            this.cH6.Width = 224;
            // 
            // school_b_rb
            // 
            this.school_b_rb.AutoSize = true;
            this.school_b_rb.Checked = true;
            this.school_b_rb.Location = new System.Drawing.Point(6, 19);
            this.school_b_rb.Name = "school_b_rb";
            this.school_b_rb.Size = new System.Drawing.Size(106, 17);
            this.school_b_rb.TabIndex = 18;
            this.school_b_rb.TabStop = true;
            this.school_b_rb.Text = "Школы(Бюджет)";
            this.school_b_rb.UseVisualStyleBackColor = true;
            this.school_b_rb.CheckedChanged += new System.EventHandler(this.school_b_rb_CheckedChanged);
            this.school_b_rb.Click += new System.EventHandler(this.radio_button_click_CheckedChanged);
            // 
            // ds_b_rb
            // 
            this.ds_b_rb.AutoSize = true;
            this.ds_b_rb.Location = new System.Drawing.Point(6, 42);
            this.ds_b_rb.Name = "ds_b_rb";
            this.ds_b_rb.Size = new System.Drawing.Size(117, 17);
            this.ds_b_rb.TabIndex = 19;
            this.ds_b_rb.Text = "Детсады(Бюджет)";
            this.ds_b_rb.UseVisualStyleBackColor = true;
            this.ds_b_rb.Click += new System.EventHandler(this.radio_button_click_CheckedChanged);
            // 
            // school_a_rb
            // 
            this.school_a_rb.AutoSize = true;
            this.school_a_rb.Location = new System.Drawing.Point(6, 65);
            this.school_a_rb.Name = "school_a_rb";
            this.school_a_rb.Size = new System.Drawing.Size(130, 17);
            this.school_a_rb.TabIndex = 19;
            this.school_a_rb.Text = "Школы(Автономные)";
            this.school_a_rb.UseVisualStyleBackColor = true;
            this.school_a_rb.Click += new System.EventHandler(this.radio_button_click_CheckedChanged);
            // 
            // ds_a_rb
            // 
            this.ds_a_rb.AutoSize = true;
            this.ds_a_rb.Location = new System.Drawing.Point(6, 88);
            this.ds_a_rb.Name = "ds_a_rb";
            this.ds_a_rb.Size = new System.Drawing.Size(141, 17);
            this.ds_a_rb.TabIndex = 19;
            this.ds_a_rb.Text = "Детсады(Автономные)";
            this.ds_a_rb.UseVisualStyleBackColor = true;
            this.ds_a_rb.Click += new System.EventHandler(this.radio_button_click_CheckedChanged);
            // 
            // rb_201_301
            // 
            this.rb_201_301.AutoSize = true;
            this.rb_201_301.Checked = true;
            this.rb_201_301.Location = new System.Drawing.Point(6, 19);
            this.rb_201_301.Name = "rb_201_301";
            this.rb_201_301.Size = new System.Drawing.Size(66, 17);
            this.rb_201_301.TabIndex = 20;
            this.rb_201_301.TabStop = true;
            this.rb_201_301.Text = "201/301";
            this.rb_201_301.UseVisualStyleBackColor = true;
            this.rb_201_301.Click += new System.EventHandler(this.radio_button_click_CheckedChanged);
            // 
            // rb_211_311
            // 
            this.rb_211_311.AutoSize = true;
            this.rb_211_311.Location = new System.Drawing.Point(6, 42);
            this.rb_211_311.Name = "rb_211_311";
            this.rb_211_311.Size = new System.Drawing.Size(66, 17);
            this.rb_211_311.TabIndex = 21;
            this.rb_211_311.Text = "211/311";
            this.rb_211_311.UseVisualStyleBackColor = true;
            this.rb_211_311.Click += new System.EventHandler(this.radio_button_click_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pdo_a_rb);
            this.groupBox1.Controls.Add(this.pdo_b_rb);
            this.groupBox1.Controls.Add(this.ds_b_rb);
            this.groupBox1.Controls.Add(this.school_b_rb);
            this.groupBox1.Controls.Add(this.school_a_rb);
            this.groupBox1.Controls.Add(this.ds_a_rb);
            this.groupBox1.Location = new System.Drawing.Point(12, 596);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 117);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // pdo_a_rb
            // 
            this.pdo_a_rb.AutoSize = true;
            this.pdo_a_rb.Location = new System.Drawing.Point(156, 42);
            this.pdo_a_rb.Name = "pdo_a_rb";
            this.pdo_a_rb.Size = new System.Drawing.Size(120, 17);
            this.pdo_a_rb.TabIndex = 21;
            this.pdo_a_rb.TabStop = true;
            this.pdo_a_rb.Text = "ПДО(Автономный)";
            this.pdo_a_rb.UseVisualStyleBackColor = true;
            this.pdo_a_rb.Click += new System.EventHandler(this.radio_button_click_CheckedChanged);
            // 
            // pdo_b_rb
            // 
            this.pdo_b_rb.AutoSize = true;
            this.pdo_b_rb.Location = new System.Drawing.Point(156, 19);
            this.pdo_b_rb.Name = "pdo_b_rb";
            this.pdo_b_rb.Size = new System.Drawing.Size(96, 17);
            this.pdo_b_rb.TabIndex = 20;
            this.pdo_b_rb.TabStop = true;
            this.pdo_b_rb.Text = "ПДО(Бюджет)";
            this.pdo_b_rb.UseVisualStyleBackColor = true;
            this.pdo_b_rb.Click += new System.EventHandler(this.radio_button_click_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_211_311);
            this.groupBox2.Controls.Add(this.rb_201_301);
            this.groupBox2.Location = new System.Drawing.Point(349, 596);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(88, 117);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // backWorker
            // 
            this.backWorker.WorkerReportsProgress = true;
            this.backWorker.WorkerSupportsCancellation = true;
            this.backWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backWorker_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 725);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem file_menu;
        private System.Windows.Forms.ToolStripMenuItem load_files_menu;
        private System.Windows.Forms.ToolStripMenuItem close_menu;
        private System.Windows.Forms.ToolStripMenuItem settingsmenu;
        private System.Windows.Forms.ToolStripMenuItem add_companies;
        private System.Windows.Forms.ToolStripMenuItem шаблоныToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader cH1;
        private System.Windows.Forms.ColumnHeader cH2;
        private System.Windows.Forms.ColumnHeader cH3;
        private System.Windows.Forms.ColumnHeader cH4;
        private System.Windows.Forms.ColumnHeader cH5;
        private System.Windows.Forms.ColumnHeader cH6;
        private System.Windows.Forms.RadioButton school_b_rb;
        private System.Windows.Forms.RadioButton ds_b_rb;
        private System.Windows.Forms.RadioButton school_a_rb;
        private System.Windows.Forms.RadioButton ds_a_rb;
        private System.Windows.Forms.RadioButton rb_201_301;
        private System.Windows.Forms.RadioButton rb_211_311;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backWorker;
        private System.Windows.Forms.RadioButton pdo_a_rb;
        private System.Windows.Forms.RadioButton pdo_b_rb;
    }
}

