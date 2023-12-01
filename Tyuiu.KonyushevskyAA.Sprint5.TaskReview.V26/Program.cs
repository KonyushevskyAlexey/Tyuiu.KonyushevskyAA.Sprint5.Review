using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using Tyuiu.KonyushevskyAA.Sprint5.TaskReview.V26.Lib;

namespace Tyuiu.KonyushevskyAA.Sprint5.TaskReview.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Конюшевский А.А | ИИПБ-23-2";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #5                                                              *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                *");
            Console.WriteLine("* Задание #Review                                                        *");
            Console.WriteLine("* Вариант #26                                                            *");
            Console.WriteLine("* Выполнил: Конюшевский Алексей Александрович  | ИИПБ-23-2               *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine(@"* Дан файл С:\DataSprint5\InPutDataFileTask7V26.txt в котором есть набор *");
            Console.WriteLine("* набор символьных данных. Заменить все английские слова на слово 'word'.*");
            Console.WriteLine("* Полученный результат сохранить в файл OutPutDataFileTask7V26.txt.      *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask7V26.txt";
            string pathSaveFile = @"C:\DataSprint5\OutPutDataTask7V26.txt";

            Console.WriteLine("Данные находятся в файле " + path);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("Находится в файле: ");
            string res = ds.LoadDataAndSave(path);
            Console.WriteLine(pathSaveFile);
            Console.ReadKey();
        }
    }
}
