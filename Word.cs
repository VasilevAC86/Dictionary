using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Word
    {
        public int Id { get; set; }
        public string Name { get; set; } // само слово
        public int Quantity { get; set; } // Кол-во повторений слово
    }
}
