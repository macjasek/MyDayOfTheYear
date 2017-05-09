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
            //Finding day of the year not using method DayOfTheYear available in DateTime
            Console.WriteLine("Podaj rok urodzenia");
            var year = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj miesiac urodzenia");
            var month = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj dzień swoich urodzin");
            var day = int.Parse(Console.ReadLine());

            var birthday = new DateTime(year,month,day);
            var dayZero = new DateTime(year - 1, 12, 31);

            var myDayOfTheYear = (birthday - dayZero).Days;

            var yesno = " nie";

            var day1 = new DateTime(year, 3, 1);
            var day2 = new DateTime(year, 2, 28);
            var daycheck = day1 - day2;

            if (daycheck.Days > 1 )
            {
                yesno = "";
            }

            Console.WriteLine($"Urodziłeś się {myDayOfTheYear} dnia roku i{yesno} był to rok przestępny.");

        }
    }
}
