using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Alarmclock
{
    class Program
    {
        private static string horizontalLine = "_______________________________";

        //Metoden ska instansiera objekt av klassen AlarmClock och testa konstruktorerna, egenskaperna och 
        //metoderna.
        static void Main(string[] args)
        {
            AlarmClock firstClock = new AlarmClock();
            ViewTestHeader("Test 1.\n Test av standardkonstruktorn.");
            Console.WriteLine(firstClock.ToString());
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Program.horizontalLine);
            Console.ResetColor();
            Console.WriteLine();

            AlarmClock secondClock = new AlarmClock(9, 42);
            ViewTestHeader("Test 2.\n Test av konstruktorn med två parametrar (9, 42).");
            Console.WriteLine(secondClock.ToString());
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Program.horizontalLine);
            Console.ResetColor();
            Console.WriteLine();

            AlarmClock thirdClock = new AlarmClock(13, 24, 7, 35);
            ViewTestHeader("Test 3.\n Test av konstruktorn med fyra parametrar (13, 24, 7, 35).");
            Console.WriteLine(thirdClock.ToString());
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Program.horizontalLine);
            Console.ResetColor();
            Console.WriteLine();

            ViewTestHeader("Test 4.\n Låt larmet gå efter 13 minuter.");
            thirdClock.AlarmHour = 13;
            thirdClock.AlarmMinute = 37;
            Run(thirdClock, 14);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Program.horizontalLine);
            Console.ResetColor();

           
            ViewTestHeader("Test 5.\n Låt larmet gå efter 6 minuter.");
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
                 sixthClock.Hour = 100;
            }
            catch (ArgumentException ex)
            {
                ViewErrorMessage(ex.Message);
            }
             Console.ForegroundColor = ConsoleColor.Blue;
             Console.WriteLine(Program.horizontalLine);
             Console.ResetColor();


             AlarmClock seventhClock = new AlarmClock();
             ViewTestHeader("Test 7.\n Test av konstruktorer så att undantag kastas \ndå tid och alarmtid tilldelas felaktiga värden.");
             try
             {
                 seventhClock.AlarmMinute = 100;
             }
             catch (ArgumentException ex)
             {
                 ViewErrorMessage(ex.Message);
             }
             Console.ForegroundColor = ConsoleColor.Blue;
             Console.WriteLine(Program.horizontalLine);
             Console.ResetColor();
        }

        //Privat statisk metod som har två parametrar.
        //Den första parametern är en referens till AlarmClock-objekt.
        // Den andra parametern är antalet minuter som AlarmClock-objektet ska gå (vilket lämpligen görs genom att låta ett
        // AlarmClock-objekt göra upprepade anrop av metoden TickTock()).
        private static void Run(AlarmClock ac, int minutes)
        {
            for (int i = 0; i < minutes; i++)
            {
                if (ac.TickTock() == true)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(ac);
                    Console.WriteLine("BEEP! BEEP! BEEP!");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(ac);
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


//NOTES
//Console.WriteLine("Ange den aktuella timmen: ");
//fourthClock.Hour = int.Parse(Console.ReadLine());
//Console.WriteLine("Ange den aktuella minuten: ");
//fourthClock.Minute = int.Parse(Console.ReadLine());
//Console.WriteLine("Ange timme för larmet: ");
//fourthClock.AlarmHour = int.Parse(Console.ReadLine());
//Console.WriteLine("Ange minuten för larmet: ");
//fourthClock.AlarmMinute = int.Parse(Console.ReadLine());




// 2.2B    samma men färre klasser? 
 //catch (Exception ex)
 //           {
 //               ViewErrorMessage(ex.Message);
 //           }
//'och sedan
//[20:53:53] Julia Källberg:         private static void ViewErrorMessage(string message)
//        {
//            Console.BackgroundColor = ConsoleColor.Red;
//            Console.ForegroundColor = ConsoleColor.White;
//            Console.WriteLine(message);
//            Console.ResetColor();
//        }
//och själkva felmeddelandet
//[20:54:17] Julia Källberg: 
//        public int Number
//        {
//            get { return _number; }
//            set
//            {
//                if (value >= 0 && value <= MaxNumber) //Om värdet som ska tilldelas _number är i det slutna intervallet mellan 0 och maxvärdet
//                {
//                    _number = value;
//                }
//                else
//                {
//                    throw new ArgumentException("Värdet är inte i rätt intervall"); //Kastar undantag om värdet som ska tilldelas _number INTE är i det slutna intervallet mellan 0 och maxvärdet
//                }
//            }
//        }
//[20:54:24] Julia Källberg: i NumberDisplay


//try{ int nummer = int.Parse(variabel) } catch { *kod som säger att variabel inte kunde vara int* }
//[21:00:09] Julia Källberg: jo men precis, skriv en try-catch-sats i test 6 och 7

//Om ni kastar ArgumentOutOfRange, då finns inte .Message, men ni kan använda ex.ParamName istället. Bara lite tips.