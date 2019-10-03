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
       public static long  year , month , week , day , hour , min , sec , time = 0;
         static void Options()
            {
              if(sec > 10 && min > 10 && hour > 10)
            {
                Console.WriteLine("   time =   " + year + " y : " + month + " m : " + week + " w : " + day + " d : " + hour + " h : " + min + " min : " + sec + " s" );
            }
            if( sec < 10 && min > 10 && hour > 10)
            {
                Console.WriteLine("   time =  " + year + " y : " + month + " m : " + week + " w : " + day + " d : " + hour + " h : " + min + " min : 0" + sec + " s" );
            }
            if( min < 10 && sec > 10 && hour > 10)
            {
                Console.WriteLine("   time =  " + year + " y : " + month + " m : " + week + " w : " + day + " d : " + hour + " h :  0" + min + " min : " + sec + " s" );
            }
            if( sec < 10 && min < 10 && hour > 10)
            {
                Console.WriteLine("   time =  " + year + " y : " + month + " m : " + week + " w : " + day + " d : " + hour + " h :  0" + min + " min :  0" + sec + " s" );
            }
            if( hour < 10 && min > 10 && sec > 10)
            {
                Console.WriteLine("   time =  " + year + " y : " + month + " m : " + week + " w : "  + day + " d :  0"+ hour + " h : " + min + " min : " + sec + " s" );
            }
            if( hour < 10 && sec < 10 && min > 10)
            {
                Console.WriteLine("   time =  " + year + " y : " + month + " m : " + week + " w : " + day + " d :  0" + hour + " h : " + min + " min :  0" + sec + " s" );
            }
            if( hour < 10 && min < 10 && sec > 10)
            {
                Console.WriteLine("   time =  " + year + " y : " + month + " m : " + week + " w : " + day + " d :  0" + hour + " h :  0" + min + " min : " + sec + " s" );
            }
            if( hour < 10 && min < 10 && sec < 10)
            {
                Console.WriteLine("   time =  " + year + " y : " + month + " m : " + week + " w : " + day + " d :  0" + hour + " h :  0" + min + " min :  0" + sec + " s" );
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
              year = time / 31104000;
              month = (time % 31104000) / 2592000;
              week = ((time % 31104000) % 2592000) / 604800;
              day = ((time % 31104000) % 2592000) % 604800 / 86400 ; 
              hour = (((time % 31104000) % 2592000) % 604800 % 86400) / 3600;
              min = ((((time % 31104000) % 2592000) % 604800 % 86400) % 3600) / 60;
             sec = ((((time % 31104000) % 2592000 ) % 604800 % 86400) % 3600) % 60;
             Console.ForegroundColor = ConsoleColor.Green;
              Options();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("   Press any key to continue! ");
            Console.ReadKey();
            Console.Clear();
            goto A;


        }
    }
}
