using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSUIR_Lab_2
{
    internal class Task2
    //Lab 2, task 2, variant 12.
    {
        public int doubleUpSymbol(char symb,  out StringBuilder resultString, params string[] arrayString)
        //удвоить каждое вхождение заданного символа
        {
            string str = String.Join(';', arrayString); // Соединение массива  строк в одну строку.
            StringBuilder strB = new StringBuilder(str); //Приведение строки типа string к типу StringBuilder.

            resultString=strB.Replace($"{symb}", $"{symb}{symb}");// Удваивание символа
            resultString.Capacity = resultString.Length; // Вырванивание буфера.

            return resultString.Capacity;
        }

        public void run()
        //удвоить каждое вхождение заданного символа x;
        {
            char x = 'x';
            string s1 = $"FFFFFF{x}FFFFFF";
            string s2 = $"RRRRRR{x}RRR{x}RRRR";
            string s3 = $"GGG{x}GGG{x}GGG{x}GGG";
            StringBuilder result;

            doubleUpSymbol(x, out result, s1, s2, s3);
            Console.WriteLine(result);

        }
    }
}
