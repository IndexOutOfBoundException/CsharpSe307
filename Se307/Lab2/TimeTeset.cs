using System;

namespace ConsoleApp1.Lab2
{
    public class TimeTest
    {
        public static void Main(string[] args)
        {
            DateTime dateTime =DateTime.Now; //Getting Current Time
            Time time = new Time(dateTime.Hour,dateTime.Minute,dateTime.Second);
            time.DisplayTime();
        }
    }
}