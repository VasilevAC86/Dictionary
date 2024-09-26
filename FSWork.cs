using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // ввод-вывод

namespace Dictionary
{
    internal class FSWork // Класс для работы с файловой системой
    {
        static char[] delimiters = { ' ', '.', ',' }; // Массив разделителей слов
        public static List<string> ReadToListOfString(string _path) // Читаем нечто в список строк
        {
            List<string> result = new List<string>();
            string _str;
            using (StreamReader sr = new StreamReader(_path))
            {
                 _str = sr.ReadToEnd();
            }
            // Массив строк, разделённых символами массива char
            result = _str.Split(delimiters).ToList<string>();
            return result;
        }
    }
}
