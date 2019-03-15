using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monthly_report
{
    class LoadFiles
    {

        FolderBrowserDialog fbd = new FolderBrowserDialog();
        string[] files;

        public  LoadFiles()
        {
        }

        public string Dir()
        {
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK)
            {
                return fbd.SelectedPath;
                
            }
            return null;
        }

        public string[] Files(string _dir)
        {
            
            if (!string.IsNullOrWhiteSpace(_dir))
            {
                string[] files = Directory.GetFiles(_dir, "*.xls");
                return files;
            }
            return null;
        }

    }


}