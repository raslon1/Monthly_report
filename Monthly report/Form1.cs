using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Monthly_report
{
    public partial class Form1 : Form
    {
        LoadFiles load_files;
        string dir;
        string[] files;
        string[] num;
        string type_educ1 = null;
        string type_educ2 = null;
        string s_col;
        string s_value;
        string e_col;
        string e_value;


        string pattern1 = @"(\d{2})|(\d{3}\-\d{4})";

        //\0702 \  775 \   09\     1 \  02   \ 42190 \111 \ 211 \ФЗ.131.03.83\611\11015\\																																
        //(\\\d{4}\\\d{3}\\\d{2}\\\d{1}\\\d{2}\\\d{5}\\\d{3}(\\\d{3}\\|\\\d{3}\.\d+))|-------------------| \d{3}
        string pattern2 = @"(\\\d{4}\\\d{3}\\\d{2}\\\d{1}\\\d{2}\\\d{5}\\\d{3}(\\\d{3}|\\\d{3}\.\d+))|(\\\d{10}\\\d{3}\\\d{4}\\\d{3})|(\d{3})";
        List<ExcelRows> elRow = new List<ExcelRows>();
        List<ExcelRows> elList = new List<ExcelRows>();


        string type_report = null;
        bool lic1Orlic2 = true;

        string[] counts = null;

        List<ExcelCounts> eEcxel = new List<ExcelCounts>();

        Add_companies add = new Add_companies();

        public Form1()
        {
            InitializeComponent();
        }

        private void load_files_menu_Click(object sender, EventArgs e)
        {

            load_files = new LoadFiles();
            dir = load_files.Dir();
            files = load_files.Files(dir);
            Text = dir;

            SelectEduc();
            Select_type_doc();
            ListEduc();
            //listBox1.Items.AddRange(files);
            //var MyDocuments = ReadXml.ReadEducation();
            ////listBox2.DataSource = SortingFiles.Sort(SortingFiles.SortGroupe(MyDocuments, "Бюджетный", "Школа"), files);
            /////listBox3.DataSource = SortingFiles.Sort(SortingFiles.SortGroupe(MyDocuments, "Бюджетный", "Детский сад"), files);
            ////listBox4.DataSource = SortingFiles.Sort(SortingFiles.SortGroupe(MyDocuments, "Автономный", "Школа"), files);
            ////listBox5.DataSource = SortingFiles.Sort(SortingFiles.SortGroupe(MyDocuments, "Автономный", "Детский сад"), files);
            //List<Company> a = SortingFiles.Edu(MyDocuments, type_educ1, type_educ2, files);


            //foreach(Company com in a)
            //{
            //    ListViewItem item = new ListViewItem(new string[] { com.Education, com.LicNumber1, com.LicNumber2, com.Type1, com.Type2, com.File });
            //    lv.Items.Add(item);
            //}


        }
        private void add_companies_Click(object sender, EventArgs e)
        {
            Add_companies add_com = new Add_companies();
            add_com.ShowDialog();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SelectEduc();
            Select_type_doc();

        }
        private void close_menu_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {


        }
        public void go(string file_path)
        {

            string selectedCountry = file_path;
            Excel ex = new Excel();
            ex.OpenDocument(selectedCountry);
            int cou = 0;

            if (rb_201_301.Checked == true)
            {
                for (int i = 1; i < ex.GetRow(); i++)
                {

                    if (Reg(ex.GetValue("A" + i.ToString()), pattern1) && Reg(ex.GetValue("G" + i.ToString()), pattern2))
                    {
                        elRow.Add(new ExcelRows
                        {
                            Group = ex.GetValue("A" + i.ToString()),
                            Kbk = ex.GetValue("G" + i.ToString()),
                            Plan_post = ex.GetValueDouable("AN" + i.ToString()),
                            Plan_vplaty = ex.GetValueDouable("BK" + i.ToString()),
                            Postuplenie = ex.GetValueDouable("CG" + i.ToString()),
                            Vplaty = ex.GetValueDouable("CT" + i.ToString())
                        });
                    }
                }

            }
            else
            {
                for (int i = 1; i < ex.GetRow(); i++)
                {

                    if (Reg(ex.GetValue("A" + i.ToString()), pattern1) || Reg(ex.GetValue("K" + i.ToString()), pattern2))
                    {
                        elRow.Add(new ExcelRows
                        {
                            Group = ex.GetValue("A" + i.ToString()),
                            Kbk = ex.GetValue("K" + i.ToString()),
                            Plan_post = ex.GetValueDouable("AK" + i.ToString()),
                            Plan_vplaty = ex.GetValueDouable("CP" + i.ToString()),
                            Postuplenie = ex.GetValueDouable("DC" + i.ToString()),

                        });
                    }
                }
            }
            ex.CloseDocument();
            ex.Dispose();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            elRow.Clear();
            backWorker.RunWorkerAsync();
        }
        private void lv_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Text = (elList.Count).ToString();
            int i = 1;
            Excel ex = new Excel();
            ex.NewDocument();

            foreach (ExcelRows el in elRow)
            {

                ex.SetValue("A" + i.ToString(), el.Group);
                ex.SetValue("B" + i.ToString(), el.Kbk);
                ex.SetNumber("C" + i.ToString(), el.Plan_post);
                ex.SetNumber("D" + i.ToString(), el.Plan_vplaty);
                ex.SetNumber("E" + i.ToString(), el.Postuplenie);
                ex.SetNumber("F" + i.ToString(), el.Vplaty);
                i++;
            }


            MessageBox.Show("ВСЕ!");
            ex.Visible = true;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Text = dir + "\\" + lv.FocusedItem.SubItems[5].Text;
        }
        public void SelectEduc()
        {

            if (school_b_rb.Checked == true)
            {

                type_educ1 = "Бюджетный";
                type_educ2 = "Школа";
                return;
            }
            else
            if (ds_b_rb.Checked == true)
            {
                type_educ1 = "Бюджетный";
                type_educ2 = "Детский сад";
                return;
            }
            else
            if (school_a_rb.Checked == true)
            {
                type_educ1 = "Автономный";
                type_educ2 = "Школа";
                return;
            }
            else
            if (ds_a_rb.Checked == true)
            {
                type_educ1 = "Автономный";
                type_educ2 = "Детский сад";
                return;
            }
            else
            if (pdo_b_rb.Checked == true)
            {
                type_educ1 = "Бюджетный";
                type_educ2 = "ПДО";
                return;
            }
            else
            if (pdo_a_rb.Checked == true)
            {
                type_educ1 = "Автономный";
                type_educ2 = "ПДО";
                return;
            }
        }
        public void Select_type_doc()
        {

            if (rb_201_301.Checked == true)
            {

                counts = null;
                lic1Orlic2 = true;
                counts = new string[] { "A", "G", "CG", "CT" };
                s_col = "A";
                s_value = "03";
                e_col = "A";
                e_value = "";
                return;

            }
            else
            if (rb_211_311.Checked == true)
            {
                counts = null;
                lic1Orlic2 = false;
                s_col = "CG";
                s_value = "8";
                e_col = "CG";
                e_value = "Всего";
                counts = new string[] { "A", "K", "CP", "DC" };
                return;
            }
        }
        public void ListEduc()
        {
            lv.Items.Clear();
            var MyDocuments = ReadXml.ReadEducation();
            //listBox2.DataSource = SortingFiles.Sort(SortingFiles.SortGroupe(MyDocuments, "Бюджетный", "Школа"), files);
            ///listBox3.DataSource = SortingFiles.Sort(SortingFiles.SortGroupe(MyDocuments, "Бюджетный", "Детский сад"), files);
            //listBox4.DataSource = SortingFiles.Sort(SortingFiles.SortGroupe(MyDocuments, "Автономный", "Школа"), files);
            //listBox5.DataSource = SortingFiles.Sort(SortingFiles.SortGroupe(MyDocuments, "Автономный", "Детский сад"), files);
            List<Company> a = SortingFiles.Edu(MyDocuments, type_educ1, type_educ2, files, lic1Orlic2);


            foreach (Company com in a)
            {
                ListViewItem item = new ListViewItem(new string[] { com.Education, com.LicNumber1, com.LicNumber2, com.Type1, com.Type2, com.File });
                lv.Items.Add(item);
            }
        }

        private void radio_button_click_CheckedChanged(object sender, EventArgs e)
        {
            SelectEduc();
            Select_type_doc();
            ListEduc();
        }

        private void backWorker_DoWork(object sender, DoWorkEventArgs e)
        {


            this.Invoke(new MethodInvoker(delegate { lv.Items[0].Focused = true; }));
            this.Invoke(new MethodInvoker(delegate { lv.Items[0].Selected = true; }));
            this.Invoke(new MethodInvoker(delegate { lv.Items[0].Selected = true; }));
            //lv.Items[0].Selected = true;
            //string[] counts = new string[] { "A", "G", "CG", "CT" };
            //listBox2.SelectedIndex =  go(items,file_path,counts);
            for (int i = 0; i < lv.Items.Count; i++)
            {
                
                this.Invoke(new MethodInvoker(delegate { lv.SelectedItems.Clear(); }));
                this.Invoke(new MethodInvoker(delegate { lv.Items[i].Focused = true; }));//lv.Items[i].Focused = true;
                this.Invoke(new MethodInvoker(delegate { lv.Items[i].Selected = true; })); //lv.Items[i].Selected = true;
                this.Invoke(new MethodInvoker(delegate { lv.Select(); }));
                this.Invoke(new MethodInvoker(delegate { if (lv.FocusedItem.SubItems[5].Text!="файл не найден") { string file_path = dir + "\\" + lv.FocusedItem.SubItems[5].Text; go(file_path); } }));

            }
        }

        private void rb_211_311_CheckedChanged(object sender, EventArgs e)
        {

        }


        Boolean Reg(string kbk, string pattern)
        {
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(kbk);
            if (matches.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void school_b_rb_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
