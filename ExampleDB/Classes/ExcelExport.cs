/*using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleDB.Classes
{
    class ExcelExport
    {
        public static bool saveExcel(string filename,string sheetname,string[,] values) {
            //Публичный статичный метод saveExcel (Имя файлв, название листа, массив со значениями)
            try
            {
               /* FileStream file = new FileStream(filename, FileMode.Create, FileAccess.Write);//Открываем файловый поток
                                                                                              //(название файла, Режим - создание, Доступ - запись)
                XSSFWorkbook workbook = new XSSFWorkbook();//Создаем документ Excel
                ISheet sheet = workbook.CreateSheet(sheetname);//Создаем лист (название листа)
                
                for (int r = 0; r < values.GetLength(0); r++) { //Цикл по строкам
                    IRow row = sheet.CreateRow(r); //Создаем строку (номер строки)

                    for (int c = 0; c < values.GetLength(1); c++) {//Цикл по столбцам
                        row.CreateCell(c).SetCellValue(values[r,c]); //Создаем ячейку (номер ячейки)
                                                                     //Задаем ее значение (значение)
                    }
                }
                workbook.Write(file);//Сохраняем файл (Поток)
                workbook.Close();//Закрываем файл*/

                return true;
            }
            catch {
                return false;
            }
            
        }
    }
}
