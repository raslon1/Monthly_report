using System;
using System.Collections.Generic;

namespace Monthly_report
{
    class SortingFiles
    {
        //public static List<String> SortGroupe(List<Company> VCom, string _type1, string _type2)
        //{
        //    List<string> lic_number = new List<string>();        
        //    int i = 0;
        //    foreach (Company c in VCom)
        //    {
        //        if (_type1 == c.Type1 && _type2 == c.Type2)
        //        {
        //            lic_number.Add(c.LicNumber1);

        //        }
        //    }
        //    return lic_number;
        //}

        //public static List<String> Sort(List<String> _lic_number, string[] _files)
        //{
        //    List<String> _lic = new List<string>();
        //    Choosefile choose_file = new Choosefile();
        //    if (_files != null)
        //    {
        //        for (int i = 0; i < _files.Length; i++)
        //        {
        //            for (int j = 0; j < _lic_number.Count; j++)
        //            {
        //                string file = System.IO.Path.GetFileName(_files[i]);
        //                if (_lic_number[j] == choose_file.choosefile(file, @"\d+"))
        //                {

        //                    _lic.Add(_files[i]);
        //                }

        //            }
        //        }
        //        return _lic;
        //    }
        //    else
        //    { return null; }
        //}

        public static string Excel_File(string lic, string[] _files)
        {
            string tlic  = "файл не найден";
            Choosefile choose_file = new Choosefile();
            if (_files != null)
            {
                for (int i = 0; i < _files.Length; i++)
                {
                    string file = System.IO.Path.GetFileName(_files[i]);
                    if (lic == choose_file.choosefile(file, @"\d+"))
                    {
                        tlic = file;
                    }

                }

                return  tlic;
                
            }
            else
            { return "файл не найден"; }
        }

        public static List<Company> Edu(List<Company> _edu, string _type1, string _type2, string[]_files, bool _lic1Orlic2)
        {
            List<Company> tEdu = new List<Company>();

            string file = null;

            foreach(Company com in _edu)
            {
                if (com.Type1 == _type1 && com.Type2 == _type2)
                {

                    if (_lic1Orlic2 == true)
                    {
                        file = Excel_File(com.LicNumber1, _files);
                    }
                    else
                    {
                        file = Excel_File(com.LicNumber2, _files);
                    }

                    tEdu.Add(new Company
                    {
                        Education = com.Education,
                        LicNumber1 = com.LicNumber1,
                        LicNumber2 = com.LicNumber2,
                        Type1 = com.Type1,
                        Type2 = com.Type2,
                        File = file
                    });

                }

            }
            return tEdu;

        }
        


    }
}
