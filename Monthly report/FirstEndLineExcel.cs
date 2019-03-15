using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace Monthly_report
{
    public class FirstEndLineExcel
    {
        public static int f_e_line(Worksheet ObjWorkSheet,Application ObjExcel, int st_line, string row, string value_row)
        {
            int lines = 0;
            bool bul = true;
            
            
            for (int i =st_line; i < 250; i++)
            {   
               
                Range range2 = ReadExcel.Read(ObjWorkSheet, row + i.ToString());//
                if ((string)range2.Text.ToString() == value_row)//
                {
                    bul = false;
                    break;
                }
                    range2 = null;        
                lines++;
                if (bul == false)
                    break;
            }
            return lines;
            ObjExcel = null;
            ObjWorkSheet = null;
            ObjExcel.Quit();
        }
       
    }
}
