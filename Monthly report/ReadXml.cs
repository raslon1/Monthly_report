using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Monthly_report
{
    public class ReadXml
    {
        //public static List<string> str = new List<string>();
        public static List<Company> ReadEducation()
        {
            List<Company> tcom = new List<Company>();
            using (FileStream fStream = new FileStream(Globals.file, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {

                try
                {
                    XmlDocument xmldoc = new XmlDocument();
                    xmldoc.Load(fStream);
                    foreach (XmlNode node in xmldoc.SelectNodes("institutions/institution"))
                    {
                        tcom.Add
                        (
                            new Company
                            {
                                Education = (node.SelectSingleNode("company").InnerText).ToString(),   
                                LicNumber1 = (node.SelectSingleNode("numer1").InnerText).ToString(),
                                LicNumber2 = (node.SelectSingleNode("numer2").InnerText).ToString(),
                                Type1 = (node.SelectSingleNode("type1").InnerText).ToString(),
                                Type2 = (node.SelectSingleNode("type2").InnerText).ToString()
                            }
                            );


                    }
                    return tcom;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    return null;
                }
            }

        }
    }
}
