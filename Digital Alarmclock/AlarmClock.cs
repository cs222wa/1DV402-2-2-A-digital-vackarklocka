using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Alarmclock
{
    class AlarmClock
    {

        private int _alarmHour;
        private int _alarmMinute;
        private int _hour;
        private int _minute;

        //Egenskap, som kapslar in det privata fältet _alarmHour. set-metoden måste validera att värdet som 
        //ska tilldelas _alarmHour är i det slutna intervallet mellan 0 och 23. Är värdet inte i intervallet ska ett 
        //undantag av typen ArgumentException kastas. 
        public int AlarmHour
        {
            get { return _alarmHour; }
            set
            {
                if (0 > value || value > 23)
                {
                    throw new ArgumentException("Värdet för alarm-timmen är inte i rätt intervall.\n Var god ange ett värde mellan 0 och 23.");
                }
                _alarmHour = value;
            }
        }

        //Egenskap, som kapslar in det privata fältet _alarmMinute. set-metoden måste validera att värdet som 
        //ska tilldelas _alarmMinute är i det slutna intervallet mellan 0 och 59. Är värdet inte i intervallet ska 
        //ett undantag av typen ArgumentException kastas.
        public int AlarmMinute
        {
            get { return _alarmMinute; }
            set
            {
                if (0 > value || value > 59)
                {
                    throw new ArgumentException("Värdet för alarm-minuten är inte i rätt intervall.\n Var god ange ett värde mellan 0 och 59.");
                }
                _alarmMinute = value;
            }
        }

        //Egenskap, som kapslar in det privata fältet _hour. set-metoden måste validera att värdet som ska 
        //tilldelas _hour är i det slutna intervallet mellan 0 och 23. Är värdet inte i intervallet ska ett undantag 
        //av typen ArgumentException kastas.
        public int Hour
        {
            get { return _hour; }
            set
            {
                if (0 > value || value > 23)
                {
                    throw new ArgumentException("Värdet för klockans timme är inte i rätt intervall.\n Var god ange ett värde mellan 0 och 23.");
                }
                _hour = value;
            }
        }


        //Egenskap, som kapslar in det privata fältet _minute. set-metoden måste validera att värdet som ska 
        //tilldelas _minute är i det slutna intervallet mellan 0 och 59. Är värdet inte i intervallet ska ett undantag 
        //av typen ArgumentException kastas.
        public int Minute
        {
            get { return _minute; }
            set
            {
                if (0 > value || value > 59)
                {
                    throw new ArgumentException("Värdet för klockans minut är inte i rätt intervall.\n Var god ange ett värde mellan 0 och 59.");
                }
                _minute = value;
            }
        }

        // Konstruktorerna.
        // Konstruktorerna, som är tre till antalet, ska se till att ett AlarmClock-objekt blir korrekt initierat. Det 
        //innebär att fälten ska tilldelas lämpliga värden

        //Standardkonstruktorn AlarmClock() ska initiera fälten till deras standardvärden. Ingen tilldelning får 
        //ske i konstruktorns kropp, som måste vara tom. Denna konstruktor måste därför anropa den 
        //konstruktor i klassen som har två parametrar.
        public AlarmClock()
        {

        }

        //Med konstruktorn AlarmClock(int hour, int minute) ska ett objekt kunna initieras så att 
        //alarmklockan ställs på den tid som parametrarna för timme respektive minut anger. Ingen tilldelning 
        //får ske i konstruktorns kropp, som måste vara tom. Denna konstruktor måste därför anropa den 
        //konstruktor i klassen som har fyra parametrar.
        public AlarmClock(int hour, int minute)
        {
            Hour = hour;
            Minute = minute;
        }

        //Med konstruktorn AlarmClock(int hour, int minute , int alarmHour, int alarmMinute)
        //ska ett objekt kunna initieras så att alarmklockan ställs på den tid och alarmtid som parametrarna 
        //anger. Detta är den enda av konstruktorerna som får innehålla kod som leder till att fält i klassen 
        //tilldelas värden.
        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
            : this(hour, minute)
        {
            AlarmHour = alarmHour;
            AlarmMinute = alarmMinute;
        }

        //Publik metod som anropas för att få klockan att gå en minut. Om den nya tiden överensstämmer med 
        //alarmtiden ska metoden returnera true, annars false. Inga utskrifter till konsolfönstret får göras av 
        //metoden.
        //Metoden ansvarar för att öka minuternas värde med 1. Värdet för minuterna måste vara i det slutna 
        //intervallet mellan 0 och 59. Då värdet för minuterna sätts till 0 ökas lämpligen timmarnas värde med 
        //1. Värdet för timmarna måste vara i det slutna intervallet mellan 0 och 23.
        public bool TickTock()
        {
            if (Minute < 59)
            {
                Minute++;
            }
            else
            {
                Minute = 0;
                if (Hour < 23)
                {
                    Hour++;
                }
                else
                {
                    Hour = 0;
                }
            }

            if (AlarmHour == Hour && AlarmMinute == Minute)
            {
                return true;
            }
            return false;                                               //Om inte kraven uppfylls returnerar metoden värdet false.
        }

        //Publik metod som har som uppgift att returnera en sträng representerande värdet av en instans av 
        //klassen AlarmClock. Inga utskrifter till konsolfönstret får göras av metoden.
        //Är timmen ett ental ska timmen presenteras utan att inledas med 0, medan då minuterna är ental ska de 
        //inledas med 0. Är klocka fem över elva på kvällen ska tiden presenteras som 23:05. Är tiden åtta 
        //minuter över sju på morgonen ska tiden presenteras som 7:08. 

        public override string ToString()
        {
            return String.Format("{0}:{1:d2} ({2}:{3:d2})", Hour, Minute, AlarmHour, AlarmMinute);
        }
    }
}

//NOTES
//Console.WriteLine("Minutes?");                Konsolen begär minuter utav användaren.
//    string minutes = Console.ReadLine();      Läser in minuter
//    int mins = int.Parse(minutes);            String mins ändras till int minutes.
//    
//        // Write line.                        Vid varje minut skrivs ett meddelande ut.
//        Console.WriteLine(new string('X', 30));

// Larmet piper 10 gånger
////for (int i = 0; i < 10; i++)
//    {
//        Console.Beep();
//    }


//while (current_time != alarm_time) {    när nuvarande tid är samma som larmtiden - sound alarm.
//    sleep(60);
//}
//sound_alarm();


//Let's say that I have a method in my application, and I want this method to be called 
//every hour on the hour (e.g. at 7:00 PM, 8:00 PM, 9:00 PM etc.). 
//I could create a Timer and set its Interval to 3600000, but eventually this would drift out of sync with the system clock. 
//Or I could use a while() loop with Thread.Sleep(n) to periodically check the system time 
//and call the method when the desired time is reached, 


//If (Format(DateTime.Now, "hh:mm") = Format(AlarmTime.Value, "hh:mm"))

//DateTime.Now.ToString("HH:mm:ss tt");
//this gives it to you as a string.