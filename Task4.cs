using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSUIR_Lab_2
{
    internal class Task4
    //Lab 2, task 4, variant 12.
    {
        public string dayAdd100Year(string dateBirth)
        // Входные данные – дата рождения(string). Выходные данные – на какой день недели
        //выпал бы ваш день рождения, если бы вы родились на 100 лет раньше(string).
        {
            DateTime date;

            if (DateTime.TryParse(dateBirth, out date))
            {
                DateTime newDate = date.AddYears(-100);
                return date.DayOfWeek.ToString();
            }
            else{
                return "Erorr Operation";
            }
        }

        public void run()
        {
            string dateBirth = "11.10.1994";
            Console.WriteLine(dayAdd100Year(dateBirth));
        }

    }
}
