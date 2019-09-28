using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Time-Converter
{
    class Program
    {
        static void Main()
        {
            A:
              int hour , min , sec , time ;
            Console.ForegroundColor = ConsoleColor.Cyan;
              Console.WriteLine("Insert the amount of time (in seconds) you want !");
              time = int.Parse(Console.ReadLine());
              hour = time / 3600;
              min = (time % 3600) / 60;
             sec = (time % 3600) % 60;
            Console.ForegroundColor = ConsoleColor.Green;
            if(sec > 10 && min > 10 && hour > 10)
            {
                Console.WriteLine("   time =   " + hour + " h : " + min + " m : " + sec + " s" );
            }
            if( sec < 10 && min > 10 && hour > 10)
            {
                Console.WriteLine("   time =  " + hour + " h : " + min + " m : 0" + sec + " s" );
            }
            if( min < 10 && sec > 10 && hour > 10)
            {
                Console.WriteLine("   time =  " + hour + " h :  0" + min + " m : " + sec + " s" );
            }
            if( sec < 10 && min < 10 && hour > 10)
            {
                Console.WriteLine("   time =  " + hour + " h :  0" + min + " m :  0" + sec + " s" );
            }
            if( hour < 10 && min > 10 && sec > 10)
            {
                Console.WriteLine("   time =   0" + hour + " h : " + min + " m : " + sec + " s" );
            }
            if( hour < 10 && sec < 10 && min > 10)
            {
                Console.WriteLine("   time =   0" + hour + " h : " + min + " m :  0" + sec + " s" );
            }
            if( hour < 10 && min < 10 && sec > 10)
            {
                Console.WriteLine("   time =   0" + hour + " h :  0" + min + " m : " + sec + " s" );
            }
            if( hour < 10 && min < 10 && sec < 10)
            {
                Console.WriteLine("   time =   0" + hour + " h :  0" + min + " m :  0" + sec + " s" );
            }
            Console.WriteLine("Press ENTER to continue ! ");
            if(Console.ReadKey().Key == ConsoleKey.Enter)
            {

            Console.Clear();
            goto A;

            }


        }
    }
}
