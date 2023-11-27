using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BSUIR_Lab_2
{
    internal class Task3
    //Lab 2, task 3, variant 12.
    {
        public string[] searchEmail(params string[] arg)
            //Найти все e-mail
        {
            StringBuilder result = new StringBuilder();
            Regex regex = new Regex(@"[A-Za-z]+[\.A-Za-z0-9_-]*[A-Za-z0-9]+@[A-Za-z]+\.[A-Za-z]+");

            foreach (string s in arg)
                //Найти все совпадения в каждой строке массива
            {
                MatchCollection reslt = regex.Matches(s);
                if (reslt.Count > 0)
                {
                    // Если совпадения есть - перебрать все резульаты и доавить в строку-результат
                    foreach (Match m in reslt)
                    {
                        result.Append(m.Value + " ");
                    }
                }
            }
            result.Capacity = result.Length; // подогнать размер буфера.
            // Вернуть массив строк со всеми  обнаруженными  e-mail в массиве строк.
            return result.ToString().Split(" ");
        }
        public void run()
        {   

            string s1 = "В этой строке два корректных e-mail. Первый aaaa12@mail.ru и  второй  bbbbb@gmail.com.";
            string s2 = "В этой строке два e-mail. Этот e-mail сссссс@rambler.com корректен. Этого .!cccc@мыла.нет не существует";
            string s3 = "В этой строке e-mail dddd_123@dom.com и  n123n123@mail.ru правильные. А _)нет@mail.ru не существует.";
            string[] email;

            email = searchEmail(s1,s2,s3);

            foreach (string s in email)
            {
                Console.WriteLine(s);
            }
        }
    }
}
