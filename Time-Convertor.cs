using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Time_Convertor
{
    class Program
    {
        static void Main()
        {
            A:
              long week , day , hour , min , sec , time = 0 ;
              Console.ForegroundColor = ConsoleColor.Cyan;
              Console.WriteLine("Insert the amount of time (in seconds) you want !");
              try
              {
                time = long.Parse(Console.ReadLine());
              }
            catch(Exception)
              {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter only numbers!");
                Thread.Sleep(3000);
                Console.Clear();
                goto A;
              }
              if(time < 0)
              {
                time = -time;
              }

              week = time / 604800;
              day = (time % 604800) / 86400 ; 
              hour = ((time % 604800) % 86400) / 3600;
              min = (((time % 604800) % 86400) % 3600) / 60;
             sec = (((time % 604800) % 86400) % 3600) % 60;
             Console.ForegroundColor = ConsoleColor.Green;
            if(sec > 10 && min > 10 && hour > 10)
            {
                Console.WriteLine("   time =   " + week + " w : " + day + " d : " + hour + " h : " + min + " m : " + sec + " s" );
            }
            if( sec < 10 && min > 10 && hour > 10)
            {
                Console.WriteLine("   time =  " + week + " w : " + day + " d : " + hour + " h : " + min + " m : 0" + sec + " s" );
            }
            if( min < 10 && sec > 10 && hour > 10)
            {
                Console.WriteLine("   time =  " + week + " w : " + day + " d : " + hour + " h :  0" + min + " m : " + sec + " s" );
            }
            if( sec < 10 && min < 10 && hour > 10)
            {
                Console.WriteLine("   time =  " + week + " w : " + day + " d : " + hour + " h :  0" + min + " m :  0" + sec + " s" );
            }
            if( hour < 10 && min > 10 && sec > 10)
            {
                Console.WriteLine("   time =  " + week + " w : "  + day + " d :  0"+ hour + " h : " + min + " m : " + sec + " s" );
            }
            if( hour < 10 && sec < 10 && min > 10)
            {
                Console.WriteLine("   time =  " + week + " w : " + day + " d :  0" + hour + " h : " + min + " m :  0" + sec + " s" );
            }
            if( hour < 10 && min < 10 && sec > 10)
            {
                Console.WriteLine("   time =  " + week + " w : " + day + " d :  0" + hour + " h :  0" + min + " m : " + sec + " s" );
            }
            if( hour < 10 && min < 10 && sec < 10)
            {
                Console.WriteLine("   time =  " + week + " w : " + day + " d :  0" + hour + " h :  0" + min + " m :  0" + sec + " s" );
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("   Press any key to continue ! ");
            Console.ReadKey();
            Console.Clear();
            goto A;


        }
    }
}
