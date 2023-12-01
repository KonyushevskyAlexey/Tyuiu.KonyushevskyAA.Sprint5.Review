using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KonyushevskyAA.Sprint5.TaskReview.V26.Lib
{
    public class DataService : ISprint5Task7V26
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = @"C:\DataSprint5\OutPutDataFileTask7V26.txt"; // Путь к файлу для сохранения результатов

            if (File.Exists(pathSaveFile))
            {
                File.Delete(pathSaveFile);
            }

            using (StreamReader reader = new StreamReader(path))
            {
                using (StreamWriter writer = new StreamWriter(pathSaveFile))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null) // Чтение файла построчно 
                    {
                        string[] words = line.Split(new char[] {' ', '\t' }, StringSplitOptions.RemoveEmptyEntries); // Разделение строки на слова

                        for (int i = 0; i < words.Length; i++)
                        {
                            if (IsEnglishWord(words[i])) // Проверка, является ли слово английским
                            {
                                words[i] = "word"; // Замена английского слова на "word"
                            }
                        }

                        string modifiedLine = string.Join(" ", words); // Объединение слов обратно в строку
                        writer.WriteLine(modifiedLine); // Запись измененной строки в новый файл
                    }
                }
            }

            Console.WriteLine("Замена выполнена успешно. Результаты сохранены в файле: " + pathSaveFile);
            return pathSaveFile;
        }

        

        static bool IsEnglishWord(string word)
        {
            foreach (char c in word)
            {
                    if (!((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')))
                    {
                        return false;
                    }

            }
            return true;
        }
    }
    
}
