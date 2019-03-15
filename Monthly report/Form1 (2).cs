using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
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
        public void go(string file_path, string _uch, string[] _counts)
        {

            int s_line;
            int e_line;
            Microsoft.Office.Interop.Excel.Application ObjExcel;
            Microsoft.Office.Interop.Excel.Workbook ObjWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ObjWorkSheet;
            try
            {
                ObjExcel = new Microsoft.Office.Interop.Excel.Application();
                ObjWorkBook = ObjExcel.Workbooks.Open(file_path, 0, false, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
                ObjWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ObjWorkBook.Sheets[1];
                s_line = (FirstEndLineExcel.f_e_line(ObjWorkSheet, ObjExcel, 1, s_col, s_value));
                e_line = (FirstEndLineExcel.f_e_line(ObjWorkSheet, ObjExcel, s_line, e_col, e_value)) + s_line;
                eEcxel.Add(new ExcelCounts { A = "", B = "", C = "", D = "", E = _uch });
                eEcxel.AddRange(ExportExcel.export_Excel(ObjWorkSheet, ObjExcel, s_line, e_line, _counts));


                //ObjWorkSheet = null;
                //ObjWorkBook.Close(false, false, false);
                //ObjWorkBook = null;
                //ObjExcel = null;
                //ObjExcel = null;
                //ObjWorkSheet = null;
                ObjExcel.Quit();
                GC.Collect();


                //return i;

            }
            catch (Exception Ex)
            {


                MessageBox.Show(Ex.ToString());
                //return 0;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (files != null)
            {
                backWorker.RunWorkerAsync();
            }

        }
        private void lv_SelectedIndexChanged(object sender, EventArgs e)
        {
            Text = lv.FocusedItem.SubItems[0].Text;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (eEcxel != null)
            {
                PrintExcel.ExportToExcel(eEcxel);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {

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

        private void school_b_rb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radio_button_click_CheckedChanged(object sender, EventArgs e)
        {
            SelectEduc();
            Select_type_doc();
            ListEduc();
        }

        private void backWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string file_no = "";
            string uch = "";
            string file_path = "";
            this.Invoke(new MethodInvoker(delegate { lv.Items[0].Focused = true; }));
            this.Invoke(new MethodInvoker(delegate { lv.Items[0].Selected = true; }));
            this.Invoke(new MethodInvoker(delegate { lv.Items[0].Selected = true; }));
            //lv.Items[0].Selected = true;
            eEcxel.Clear();
            //string[] counts = new string[] { "A", "G", "CG", "CT" };
            //listBox2.SelectedIndex =  go(items,file_path,counts);
            for (int i = 0; i < lv.Items.Count; i++)
            {
                this.Invoke(new MethodInvoker(delegate { lv.Items[i].Focused = true; }));//lv.Items[i].Focused = true;
                this.Invoke(new MethodInvoker(delegate { lv.Items[i].Selected = true; })); //lv.Items[i].Selected = true;
                this.Invoke(new MethodInvoker(delegate { uch = lv.FocusedItem.SubItems[0].Text; }));
                this.Invoke(new MethodInvoker(delegate { file_path = dir + @"\" + lv.FocusedItem.SubItems[5].Text; }));

                this.Invoke(new MethodInvoker(delegate { file_no = lv.FocusedItem.SubItems[5].Text; }));

                if (file_no != "файл не найден")
                {
                    go(file_path, uch, counts);
                }
            }
        }

    }
}
