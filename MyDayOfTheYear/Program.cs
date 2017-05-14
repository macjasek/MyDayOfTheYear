using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDayOfTheYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj rok urodzenia");
            int year = int.Parse(Console.ReadLine());

            //sprawdzenie czy rok przestępny
            string yesno = " nie";
            int lapYear = 0;

            if ((year % 4) == 0)
            {
                yesno = "";
                lapYear = 1;
            }

            Console.WriteLine("Podaj miesiac urodzenia");
            int month = int.Parse(Console.ReadLine());

            while (month < 1 || month > 12)
            {
                Console.WriteLine("Miesiac powinien byc liczba w przedziale od 1 do 12");
                month = int.Parse(Console.ReadLine());
            }

            var daysArray = new int[] { 0, 31, 28 + lapYear, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            Console.WriteLine("Podaj dzien swoich urodzin");
            int day = int.Parse(Console.ReadLine());

            while (day > daysArray[month])
            {
                Console.WriteLine($"Maksymalna liczba dni w {month} miesiacu roku to {daysArray[month]}.");
                Console.WriteLine("Podaj dzien swoich urodzin");
                day = int.Parse(Console.ReadLine());
            }

            int myDayOfTheYear = day;

            for (int i = 0; i < month; i++)
            {
                myDayOfTheYear += daysArray[i];  
            }

            Console.WriteLine($"Dzien Twoich urodzin byl {myDayOfTheYear} dniem roku i{yesno} byl to rok przestępny.");
        }
    }
}
