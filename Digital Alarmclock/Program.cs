using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Alarmclock
{
    class Program
    {
        private static string horizontalLine = "_______________________________";  //En linje.

        //Metoden ska instansiera objekt av klassen AlarmClock och testa konstruktorerna, egenskaperna och 
        //metoderna.
        static void Main(string[] args)
        {
            AlarmClock firstClock = new AlarmClock();  
            ViewTestHeader("Test 1.\n Test av standardkonstruktorn.");  //Konstruktorn visas som nollställd.
            Console.WriteLine(firstClock.ToString());
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Program.horizontalLine);
            Console.ResetColor();
            Console.WriteLine();

            AlarmClock secondClock = new AlarmClock(9, 42);
            ViewTestHeader("Test 2.\n Test av konstruktorn med två parametrar (9, 42).");  //Konstruktorn visar klockans tid och nollor för larmet-tiden.
            Console.WriteLine(secondClock.ToString());
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Program.horizontalLine);
            Console.ResetColor();
            Console.WriteLine();

            AlarmClock thirdClock = new AlarmClock(13, 24, 7, 35);
            ViewTestHeader("Test 3.\n Test av konstruktorn med fyra parametrar (13, 24, 7, 35)."); //Konstruktorn visar klockan och larm-tiden.
            Console.WriteLine(thirdClock.ToString());
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Program.horizontalLine);
            Console.ResetColor();
            Console.WriteLine();

            ViewTestHeader("Test 4.\n Låt larmet gå efter 13 minuter.");  //Klockan ställs att gå i 14 minuter, där larmet går efter 13 minuter.
            thirdClock.AlarmHour = 13;
            thirdClock.AlarmMinute = 37;
            Run(thirdClock, 14);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Program.horizontalLine);
            Console.ResetColor();

           
            ViewTestHeader("Test 5.\n Låt larmet gå efter 6 minuter."); //Samma klocka ställs att gå 7 minuter, där larmet går efter 6 minuter.
            thirdClock.AlarmHour = 13;
            thirdClock.AlarmMinute = 44;
            Run(thirdClock, 7);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Program.horizontalLine);
            Console.ResetColor();


            AlarmClock sixthClock = new AlarmClock();
            ViewTestHeader("Test 6.\n Test av egenskaperna så att undantag kastas\ndå tid och alarmtid tilldelas felaktiga värden.");
             try
            {
                sixthClock.Hour = 100;  //Timmen ställs till 100, vilket inte ligger i intervallet 0-23.
            }
            catch (ArgumentException ex) //Undantaget som kastas fångas upp...
            {
                ViewErrorMessage(ex.Message);  //... och ett felmeddelande skrivs ut.
            }
             Console.ForegroundColor = ConsoleColor.Blue;
             Console.WriteLine(Program.horizontalLine);  //En blå linje skrivs ut för att skilja testerna åt.
             Console.ResetColor();


             AlarmClock seventhClock = new AlarmClock();
             ViewTestHeader("Test 7.\n Test av konstruktorer så att undantag kastas \ndå tid och alarmtid tilldelas felaktiga värden.");
             try
             {
                 seventhClock.AlarmMinute = 100;   //Alarm-timmen ställs till 100, vilket inte ligger i intervallet 0-23.
             }
             catch (ArgumentException ex)  //Undantaget som kastas fångas upp...
             {
                 ViewErrorMessage(ex.Message);  //... och ett felmeddelande skrivs ut.
             }
             Console.ForegroundColor = ConsoleColor.Blue;
             Console.WriteLine(Program.horizontalLine); //En blå linje skrivs ut för att skilja testerna åt.
             Console.ResetColor();
        }

        //Privat statisk metod som har två parametrar.
        //Den första parametern är en referens till AlarmClock-objekt.
        // Den andra parametern är antalet minuter som AlarmClock-objektet ska gå (vilket lämpligen görs genom att låta ett
        // AlarmClock-objekt göra upprepade anrop av metoden TickTock()).
        private static void Run(AlarmClock ac, int minutes)
        {
            for (int i = 0; i < minutes; i++)  //Loopen körs tills den ppfyllt värdet för "minutes". 
            {
                if (ac.TickTock() == true)
                {
                    Console.BackgroundColor = ConsoleColor.Blue; //Om TickTock() returnerar true under den tiden så går larmet.
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(ac);
                    Console.WriteLine("BEEP! BEEP! BEEP!");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(ac);   //Om inte tiden för klockan och larmtiden stämmer överrens skrivs bara tiden ut.
                }
            }
        }

        //Privat statisk metoden som tar ett felmeddelande som argument och presenterar det.
        private static void ViewErrorMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        //Privat statisk metod som tar en sträng som argument och presenterar strängen.
        private static void ViewTestHeader(string header)
        {
            Console.WriteLine(header);
        }
    }
}

