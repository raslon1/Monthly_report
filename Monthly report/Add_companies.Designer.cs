namespace Monthly_report
{
    partial class Add_companies
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Бюджетные школы", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Бюжджетные детсады", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Автономные школы", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Автономные детсады", System.Windows.Forms.HorizontalAlignment.Left);
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.name_tBox = new System.Windows.Forms.TextBox();
            this.lic1_tBox = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_lic = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lic2_tBox = new System.Windows.Forms.TextBox();
            this.cb_type1 = new System.Windows.Forms.ComboBox();
            this.cb_type2 = new System.Windows.Forms.ComboBox();
            this.lv = new System.Windows.Forms.ListView();
            this.cH1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cH2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cH3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cH4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cH5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(12, 470);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Добавить";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(93, 470);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Выход";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // name_tBox
            // 
            this.name_tBox.Location = new System.Drawing.Point(138, 382);
            this.name_tBox.Name = "name_tBox";
            this.name_tBox.Size = new System.Drawing.Size(356, 20);
            this.name_tBox.TabIndex = 4;
            // 
            // lic1_tBox
            // 
            this.lic1_tBox.Location = new System.Drawing.Point(138, 408);
            this.lic1_tBox.Name = "lic1_tBox";
            this.lic1_tBox.Size = new System.Drawing.Size(100, 20);
            this.lic1_tBox.TabIndex = 5;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(12, 385);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(123, 13);
            this.lbl_name.TabIndex = 9;
            this.lbl_name.Text = "Название учреждения:";
            // 
            // lbl_lic
            // 
            this.lbl_lic.AutoSize = true;
            this.lbl_lic.Location = new System.Drawing.Point(12, 411);
            this.lbl_lic.Name = "lbl_lic";
            this.lbl_lic.Size = new System.Drawing.Size(125, 13);
            this.lbl_lic.TabIndex = 10;
            this.lbl_lic.Text = "Номер лицевого счета:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Тип учреждения:";
            // 
            // lic2_tBox
            // 
            this.lic2_tBox.Location = new System.Drawing.Point(248, 408);
            this.lic2_tBox.Name = "lic2_tBox";
            this.lic2_tBox.Size = new System.Drawing.Size(100, 20);
            this.lic2_tBox.TabIndex = 12;
            // 
            // cb_type1
            // 
            this.cb_type1.FormattingEnabled = true;
            this.cb_type1.Items.AddRange(new object[] {
            "Бюджетный",
            "Автономный"});
            this.cb_type1.Location = new System.Drawing.Point(137, 434);
            this.cb_type1.Name = "cb_type1";
            this.cb_type1.Size = new System.Drawing.Size(100, 21);
            this.cb_type1.TabIndex = 13;
            // 
            // cb_type2
            // 
            this.cb_type2.FormattingEnabled = true;
            this.cb_type2.Items.AddRange(new object[] {
            "Школа",
            "Детский сад",
            "ПДО"});
            this.cb_type2.Location = new System.Drawing.Point(248, 434);
            this.cb_type2.Name = "cb_type2";
            this.cb_type2.Size = new System.Drawing.Size(100, 21);
            this.cb_type2.TabIndex = 14;
            // 
            // lv
            // 
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cH1,
            this.cH2,
            this.cH3,
            this.cH4,
            this.cH5});
            this.lv.FullRowSelect = true;
            listViewGroup1.Header = "Бюджетные школы";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup1.Tag = "0";
            listViewGroup2.Header = "Бюжджетные детсады";
            listViewGroup2.Name = "listViewGroup2";
            listViewGroup2.Tag = "1";
            listViewGroup3.Header = "Автономные школы";
            listViewGroup3.Name = "listViewGroup3";
            listViewGroup3.Tag = "2";
            listViewGroup4.Header = "Автономные детсады";
            listViewGroup4.Name = "listViewGroup4";
            listViewGroup4.Tag = "3";
            this.lv.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4});
            this.lv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv.Location = new System.Drawing.Point(12, 12);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(569, 364);
            this.lv.TabIndex = 16;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
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
            // Add_companies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 504);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.cb_type2);
            this.Controls.Add(this.cb_type1);
            this.Controls.Add(this.lic2_tBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_lic);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lic1_tBox);
            this.Controls.Add(this.name_tBox);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_add);
            this.Name = "Add_companies";
            this.Text = "Add_companies";
            this.Load += new System.EventHandler(this.Add_companies_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox name_tBox;
        private System.Windows.Forms.TextBox lic1_tBox;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_lic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lic2_tBox;
        private System.Windows.Forms.ComboBox cb_type1;
        private System.Windows.Forms.ComboBox cb_type2;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader cH1;
        private System.Windows.Forms.ColumnHeader cH2;
        private System.Windows.Forms.ColumnHeader cH3;
        private System.Windows.Forms.ColumnHeader cH4;
        private System.Windows.Forms.ColumnHeader cH5;
    }
}