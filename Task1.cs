using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSUIR_Lab_2
{
    internal class Task1
    //Lab 2, task 1, variant 12.
    {
        public void searshFirstLastSymbol(string text,char symbol , out int first, out int last)
           // найти порядковые номера первого и последнего вхождения символа x;
        {
            first = text.IndexOf(symbol);
            last = text.LastIndexOf(symbol);
        }

        public void run()
        {
            string text = "В этой строке нет искомого символа.";
            string text2 = "В этой строке символ x  встречает 2 раза.Второе вхождение x в строку.";
            char x = 'x';
            int first, last;

            searshFirstLastSymbol(text, x, out first, out last);
            Console.WriteLine($"Первое вхождение символа {x}: {first}. Последние вхождение символа {x}: {last}");

            searshFirstLastSymbol(text2, x, out first, out last);
            Console.WriteLine($"Первое вхождение символа {x}: {first}. Последние вхождение символа {x}: {last}");
        }
    }
}
