using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monthly_report
{
    class ReadExcel
    {
        public static Range Read(Worksheet ObjWorkSheet, string value)
        {
            Range range = ObjWorkSheet.get_Range(value, value);

            return range;
            range = null;
        }
    }
}
