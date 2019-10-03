using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Time_Converter
{
    class Program
    {
        public static long year, month, week, day, hour, min, sec, time = 0;

        static void AddZeros()
        {
            for (int i = 0; i <= 7; i++)
            {
                switch (i)
                {
                    case 0:
                        if (year < 10) Console.Write("time = 0" + year + " y : ");
                        else Console.Write("time =  " + year + " y : ");
                        break;
                    case 1:
                        if (month < 10) Console.Write("0" + month + " m : ");
                        else Console.Write(month + " m : ");
                        break;
                    case 2:
                        if (week < 10) Console.Write("0" + week + " w : ");
                        else Console.Write(week + " w : ");
                        break;
                    case 3:
                        if (day < 10) Console.Write("0" + day + " d : ");
                        else Console.Write(day + " d : ");
                        break;
                    case 4:
                        if (hour < 10) Console.Write("0" + hour + " h : ");
                        else Console.Write(hour + " h : ");
                        break;
                    case 5:
                        if (min < 10) Console.Write("0" + min + " min : ");
                        else Console.Write(min + " min : ");
                        break;
                    case 6:
                        if (sec < 10) Console.Write("0" + sec + " s  ");
                        else Console.Write(sec + " s  ");
                        break;
                }
            }

        }
        static void Main()
        {
        A:
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Insert the amount of time (in seconds) you want!");
            try
            {
                time = long.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter only numbers!");
                Thread.Sleep(3000);
                Console.Clear();
                goto A;
            }
            if (time < 0)
            {
                time = -time;
            }
            year = time / 31104000;
            month = (time % 31104000) / 2592000;
            week = ((time % 31104000) % 2592000) / 604800;
            day = ((time % 31104000) % 2592000) % 604800 / 86400;
            hour = (((time % 31104000) % 2592000) % 604800 % 86400) / 3600;
            min = ((((time % 31104000) % 2592000) % 604800 % 86400) % 3600) / 60;
            sec = ((((time % 31104000) % 2592000) % 604800 % 86400) % 3600) % 60;
            
            Console.ForegroundColor = ConsoleColor.Green;
            AddZeros();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("   Press any key to continue! ");
            Console.ReadKey();
            Console.Clear();
            goto A;


        }
    }
}
