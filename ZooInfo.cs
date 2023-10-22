using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6__OOP_Arv
{
    public class ZooInfo
    {
        public DateTime _Opening { get; set; } //Öppningstider
        public DateTime _Closing { get; set; } //Stängingstider

        public void ShowTimeInfo(int year, int month, int day, int openHour, int openMinute, int closeHour, int closeMinute) //Metod för visa öppning och stängning
        {
            Console.WriteLine("Welcome to Zoo OOP");
            _Opening = new DateTime (year, month, day, openHour, openMinute, 0);
            _Closing = new DateTime(year, month, day, closeHour, closeMinute, 0);

            Console.WriteLine($"The opening and closing times for today is as following: \nOpen:{_Opening} \nClosing:{_Closing}"); //skriver ut info
            Console.WriteLine("");
        }
    }
    
}
