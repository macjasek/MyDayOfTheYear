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
            Console.WriteLine("Podaj miesiac urodzenia");
            int month = int.Parse(Console.ReadLine());

            while (month < 1 || month > 12)
            {
                Console.WriteLine("Miesiac powinien byc liczba w przedziale od 1 do 12");
                month = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Podaj dzien swoich urodzin");
            int day = int.Parse(Console.ReadLine());

            var birthday = new DateTime(year,month,day);
            var dayZero = new DateTime(year - 1, 12, 31);

            int myDayOfTheYear = (birthday - dayZero).Days;

            string yesno = " nie";

            //sprawdzenie czy rok przestępny
            var day1 = new DateTime(year, 3, 1);
            var day2 = new DateTime(year, 2, 28);
            TimeSpan daycheck = day1 - day2;

            if (daycheck.Days > 1 )
            {
                yesno = "";
            }

            Console.WriteLine($"Dzien Twoich urodzin byl {myDayOfTheYear} dniem roku i{yesno} byl to rok przestępny.");

        }
    }
}
