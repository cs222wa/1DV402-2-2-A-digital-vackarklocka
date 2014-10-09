using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Alarmclock
{
    class AlarmClock
    {
        //Egenskap, som kapslar in det privata fältet _alarmHour. set-metoden måste validera att värdet som 
        //ska tilldelas _alarmHour är i det slutna intervallet mellan 0 och 23. Är värdet inte i intervallet ska ett 
        //undantag av typen ArgumentException kastas. 
        public int AlarmHour {get; set;}
        int _alarmHour;

        //Egenskap, som kapslar in det privata fältet _alarmMinute. set-metoden måste validera att värdet som 
        //ska tilldelas _alarmMinute är i det slutna intervallet mellan 0 och 59. Är värdet inte i intervallet ska 
        //ett undantag av typen ArgumentException kastas.
        public int AlarmMinute {get; set;}
        int _alarmMinute;

        //Egenskap, som kapslar in det privata fältet _hour. set-metoden måste validera att värdet som ska 
        //tilldelas _hour är i det slutna intervallet mellan 0 och 23. Är värdet inte i intervallet ska ett undantag 
        //av typen ArgumentException kastas.
        int Hour {get; set;}
        int _hour;

        //Egenskap, som kapslar in det privata fältet _minute. set-metoden måste validera att värdet som ska 
        //tilldelas _minute är i det slutna intervallet mellan 0 och 59. Är värdet inte i intervallet ska ett undantag 
        //av typen ArgumentException kastas.
        int Minute {get; set;}
        int _minute;

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

        }

        //Med konstruktorn AlarmClock(int hour, int minute , int alarmHour, int alarmMinute)
        //ska ett objekt kunna initieras så att alarmklockan ställs på den tid och alarmtid som parametrarna 
        //anger. Detta är den enda av konstruktorerna som får innehålla kod som leder till att fält i klassen 
        //tilldelas värden.
        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
        {

        }
        //Publik metod som anropas för att få klockan att gå en minut. Om den nya tiden överensstämmer med 
        //alarmtiden ska metoden returnera true, annars false. Inga utskrifter till konsolfönstret får göras av 
        //metoden.
        //Metoden ansvarar för att öka minuternas värde med 1. Värdet för minuterna måste vara i det slutna 
        //intervallet mellan 0 och 59. Då värdet för minuterna sätts till 0 ökas lämpligen timmarnas värde med 
        //1. Värdet för timmarna måste vara i det slutna intervallet mellan 0 och 23.
        public bool TickTock()
        {
            return false;
        }

        //Publik metod som har som uppgift att returnera en sträng representerande värdet av en instans av 
        //klassen AlarmClock. Inga utskrifter till konsolfönstret får göras av metoden.
        //Är timmen ett ental ska timmen presenteras utan att inledas med 0, medan då minuterna är ental ska de 
        //inledas med 0. Är klocka fem över elva på kvällen ska tiden presenteras som 23:05. Är tiden åtta 
        //minuter över sju på morgonen ska tiden presenteras som 7:08. 
        public string ToString()
        {
            
        }
    }
}
