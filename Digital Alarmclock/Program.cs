using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Alarmclock
{
    class Program
    {
        private static string horizontalLine;

        public string HorizontalLine
        {
            get { return horizontalLine; }
            set
            {
                horizontalLine = "════════════════════════════════════════";
            }
        }

        //Metoden ska instansiera objekt av klassen AlarmClock och testa konstruktorerna, egenskaperna och 
        //metoderna.
        static void Main(string[] args)
        {
            AlarmClock ac = new AlarmClock(10, 15, 10, 30);

            AlarmClock clock = new AlarmClock();
            ViewTestHeader("Test 1. Test av standardkonstruktorn.");
            string time = clock.ToString();
            Console.WriteLine(time);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Program.horizontalLine);
            Console.ResetColor();
            Console.WriteLine();

            AlarmClock secondClock = new AlarmClock(9, 42);
            ViewTestHeader("Test 2. Test av konstruktorn med två parametrar (9, 42).");
            string secondTime = secondClock.ToString();
            Console.Write(secondTime);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Program.horizontalLine);
            Console.ResetColor();
            Console.WriteLine();

            AlarmClock thirdClock = new AlarmClock(13, 24, 7, 35);
            ViewTestHeader("Test 3. Test av konstruktorn med fyra parametrar (13, 24, 7, 35).");
            string thirdTime = thirdClock.ToString();
            Console.WriteLine(thirdTime);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Program.horizontalLine);
            Console.ResetColor();
            Console.WriteLine();

            AlarmClock fourthClock = new AlarmClock(23, 58, 0, 11);
            ViewTestHeader("Test 4. Låt larmet gå efter 13 minuter.");
            for (int i = 0; i < 15; i++)
            {
                if (fourthClock.TickTock() == true)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    string fourthTime = fourthClock.ToString();
                    Console.Write(fourthTime);
                    Console.WriteLine("BEEP! BEEP! BEEP!");
                    Console.ResetColor();
                }
                else
                {
                    string fourthTime = fourthClock.ToString();
                    Console.WriteLine(fourthTime);
                }
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Program.horizontalLine);
            Console.ResetColor();

            AlarmClock fifthClock = new AlarmClock(6, 12, 6, 15);
            ViewTestHeader("Test 5. Låt larmet gå efter 6 minuter.");
            for (int i = 0; i < 6; i++)
            {
                if (fifthClock.TickTock() == true)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    string fifthTime = fifthClock.ToString();
                    Console.Write(fifthTime);
                    Console.WriteLine("BEEP! BEEP! BEEP!");
                    Console.ResetColor();
                }
                else
                {
                    string fifthTime = fifthClock.ToString();
                    Console.WriteLine(fifthTime);
                }
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Program.horizontalLine);
            Console.ResetColor();

            //AlarmClock sixthClock = new AlarmClock(44, 60, 25, 81);
            //ViewTestHeader("Test 6. Test av egenskaperna så att undantag kastas då tid och alarmtid tilldelas felaktiga värden.");
            //for (int i = 0; i < 20; i++)
            //{
            //    if (sixthClock.TickTock() == true)
            //    {
            //        Console.BackgroundColor = ConsoleColor.Blue;
            //        Console.ForegroundColor = ConsoleColor.White;
            //        string sixthTime = sixthClock.ToString();
            //        Console.Write(sixthTime);
            //        Console.WriteLine("BEEP! BEEP! BEEP!");
            //        Console.ResetColor();
            //    }
            //    else
            //    {
            //        string sixthTime = sixthClock.ToString();
            //        Console.WriteLine(sixthTime);
            //    }
            //}

            //AlarmClock seventhClock = new AlarmClock(44, 60, 25, 81);
            //ViewTestHeader("Test 7. Test av konstruktorer så att undantag kastas då tid och alarmtid tilldelas felaktiga värden.");
            //string seventhTime = seventhClock.ToString();
            //Console.WriteLine(seventhTime);
            //Console.WriteLine();
            //Console.ForegroundColor = ConsoleColor.Blue;
            //Console.WriteLine(Program.horizontalLine);
            //Console.ResetColor();

            //Man kan självklart dela upp detta i återanvändningsbara funktioner, men prova först 
            //att få koden att fungera utan detta. Därefter se om du kan göra koden mer 
            //återanvändningsbar med att göra en funktion som gör mycket jobbet för dig.

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Program.horizontalLine);
            Console.ResetColor();
            Console.WriteLine("AlarmClock");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Program.horizontalLine);
            Console.ResetColor();
            Console.WriteLine();
            Program.Run(ac, 20);
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
                    string acTime = ac.ToString();
                    Console.Write(acTime);
                    Console.WriteLine("BEEP! BEEP! BEEP!");
                    Console.ResetColor();
                }
                else
                {
                    string acTime = ac.ToString();
                    Console.WriteLine(acTime);
                }
            }
        }

        //Privat statisk metoden som tar ett felmeddelande som argument och presenterar det.
        private void ViewErrorMessage(string message)
        {
            Console.WriteLine(message);
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