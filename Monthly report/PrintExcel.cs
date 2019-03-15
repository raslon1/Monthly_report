using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monthly_report
{
    class PrintExcel
    {
        //public static List<String> rows(List<ExcelCounts> excel)
        //{
        //    List<String> A = new List<string>();
        //    foreach (ExcelCounts ec in excel)
        //    {
        //        A.Add(ec.B);
        //    }
        //    return A;
        //}

        public static void ExportToExcel(List<ExcelCounts> tEcxel)
        {
            //= @"(?<=ФИО РЕБ.:)(\w*\s*\w*\s*\w*)";
            //= @"(?<=ТАБЕЛ.N:)(\d+)";
            // Загрузить Excel, затем создать новую пустую рабочую книгу
            Application excelApp = new Application();

            // Сделать приложение Excel видимым
            excelApp.Visible = true;
            excelApp.Workbooks.Add();
            Worksheet workSheet = excelApp.ActiveSheet;
            // Установить заголовки столбцов в ячейках
            workSheet.Range["A1"].ColumnWidth = 15;
            workSheet.Range["B1"].ColumnWidth = 80;
            workSheet.Range["C1"].ColumnWidth = 15;
            workSheet.Range["D1"].ColumnWidth = 15;
            workSheet.Range["E1"].ColumnWidth = 15;
            workSheet.Cells[1, "A"] = "Группа";
            workSheet.Cells[1, "B"] = "Код по бюджетной классификации РФ";
            workSheet.Cells[1, "C"] = "Поступления";
            workSheet.Cells[1, "D"] = "Выплаты";
            
            int row = 1;
            
            foreach (ExcelCounts c in tEcxel)
            {
                row++;
                workSheet.Cells.NumberFormat = "@";
                //workSheet.Range["A" + row.ToString()].WrapText = true;
                workSheet.Cells[row, "A"] = c.A;
                workSheet.Cells[row, "B"] = c.B;
                workSheet.Cells[row, "C"] = c.C;
                workSheet.Cells[row, "D"] = c.D;
                workSheet.Cells[row, "E"] = c.E;
            }
           

        }

        // Придать симпатичный вид табличным данным

        //workSheet.Range["A1"].WrapText = true;

        // workSheet.Range["A1"].AutoFormat(Excel.XlRangeAutoFormat.xlRangeAutoFormatClassic2);

        // Сохранить файл, выйти из Excel

        // убрать предупреждения!!! нужно для перезаписи
        //excelApp.DisplayAlerts = false;
        //workSheet.SaveAs(string.Format(@"{0}\Price.xlsx", Environment.CurrentDirectory));

        

    }
}
