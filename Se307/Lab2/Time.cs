using System;

namespace ConsoleApp1.Lab2
{
    public class Time
    {
        private int hour, min, sec;

        // SETTERS AND GETTERS
        public int Hour
        {
            get => hour;
            set => hour = value;
        }

        public int Min
        {
            get => min;
            set => min = value;
        }

        public int Sec
        {
            get => sec;
            set => sec = value;
        }

        public Time(int hour, int min, int sec)
        {
            this.hour = hour;
            this.min = min;
            this.sec = sec;
        }
                //Current Time
        public void DisplayTime()
        {
            Console.WriteLine("Current Time: " +hour + ":" + min + ":" + sec);
        }
    }
}