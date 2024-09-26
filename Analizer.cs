using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity; // добавляем

namespace Dictionary
{
    // Сравнивает содержимое БД с тем, что считано из списка, добавляет кол-во повторений слова
    internal class Analizer 
    {
        static List<Word> words;
        public static List<Word> GetListOfWord(List<string> _lst) // метод возврата слов
        {
            List<Word> result = new List<Word>();
            int count = 0; // Счётчик кол-ва повторений
            string _tmp; // Временная переменная для хранения слова
            do
            {
                // Вхождение 1-ого слова - результат -> count
                // _tmp = 1-ое слово
                // Удалить все вхождения слова в список RemoveAll
                // Добавить в result слово и его кол-во count: result.add(tmp, count)
            } while (_lst.Count > 0);
            return result;
        }
    }
}