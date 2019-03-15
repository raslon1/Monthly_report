using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Monthly_report
{
    public partial class Add_companies : Form
    {
        FileStream fStream;
        string path = Globals.file;
        XmlDocument xmlDoc;
        public Add_companies()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void CreateXMLDocument(string filepath)
        {
            //XmlTextWriter xtw = new XmlTextWriter(filepath, Encoding.UTF8);

            //xtw.WriteEndElement();
            //xtw.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            List<string> fildes = new List<string> { };
            fildes.Add(name_tBox.Text);
            fildes.Add(lic1_tBox.Text);
            fildes.Add(lic2_tBox.Text);
            fildes.Add(cb_type1.Text);
            fildes.Add(cb_type2.Text);

            MessageBox.Show(AddEducation(fildes));
            ReadEducation();
        }

        bool CheckForExistPersonByName(string name, string surName)
        {
            using (FileStream fStream = new FileStream(Globals.file, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                System.Xml.XmlDocument CXML = new System.Xml.XmlDocument();
                CXML.Load(fStream);

                for (int i = 0; i < CXML.DocumentElement.ChildNodes.Count; i++)
                {
                    string fname = String.Format("{0}",
                     CXML.DocumentElement.ChildNodes[i].FirstChild.InnerText);
                    string fsurname =
                     CXML.DocumentElement.ChildNodes[i].FirstChild.
              NextSibling.InnerText;
                    if (name == fname && surName == fsurname)
                        return true;
                }
            }

            return false;
        }

        string AddEducation(List<string> newData)
        {
            string[] tagName = Globals.fields;


            if (CheckForExistPersonByName(newData[0], newData[1]))
                return "Такая учреждение уже имеется в БД";
            try
            {
                //create the reader filestream (fs)   
                using (fStream = new FileStream(path, FileMode.Open,
                   FileAccess.Read, FileShare.ReadWrite))
                {
                    //Create the xml document   
                    xmlDoc = new XmlDocument();

                    //Load the xml document   
                    xmlDoc.Load(fStream);

                    //Close the fs filestream   
                    fStream.Close();
                }
            }
            catch
            {
                return "Учреждение не была добавлена";
            }

            try
            {
                XmlElement newitem;
                XmlElement newOUTERitem =
                  xmlDoc.CreateElement("institution");

                for (int i = 0; i < tagName.Length; i++)
                {
                    // create the new element (node)  
                    newitem = xmlDoc.CreateElement(tagName[i]);

                    // Put the value (inner Text) into the node   
                    newitem.InnerText = newData[i];
                    // Close node  
                    newOUTERitem.AppendChild(newitem);
                }
                // Close outer node  
                xmlDoc.DocumentElement.InsertAfter(
                  newOUTERitem, xmlDoc.DocumentElement.LastChild);

                //Save the XML file   
                FileStream WRITER = new FileStream(path, FileMode.Truncate, FileAccess.Write,
                  FileShare.ReadWrite);

                xmlDoc.Save(WRITER);

                //Close the writer filestream   
                WRITER.Close();
                return "Добавлено!";

            }
            catch
            {
                return "Учреждение не была добавлена";
            }
        }

        public void ReadEducation()
        {
            using (FileStream fStream = new FileStream(Globals.file, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                Company com = new Company();
                try
                {
                    XmlDocument xmldoc = new XmlDocument();
                    xmldoc.Load(fStream);
                    foreach (XmlNode node in xmldoc.SelectNodes("institutions/institution"))
                    {
                        com.Education = (node.SelectSingleNode("company").InnerText);
                        com.LicNumber1 = (node.SelectSingleNode("numer1").InnerText);
                        com.LicNumber2 = (node.SelectSingleNode("numer2").InnerText);
                        com.Type1 = (node.SelectSingleNode("type1").InnerText);
                        com.Type2 = (node.SelectSingleNode("type2").InnerText);
                        ListViewItem item = new ListViewItem(new string[] { com.Education, com.LicNumber1, com.LicNumber2, com.Type1, com.Type2 });
                        lv.Items.Add(item);
                    }
                }
                catch { }
            }

        }

        void XmlDelete()
        {

        }

        private void Add_companies_Load(object sender, EventArgs e)
        {
            ReadEducation();
        }
    }
}
