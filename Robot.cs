using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureHR
{
    public class Robot : IInteractionsWithPeople
    {
        /*
         Klasa Robot odzwierciedla dość interaktywną maszynę (implementuje interfejs IInteractionsWithPeople, co oznacza, że potrafi porozumiewać się z ludźmi). Brakuje tej klasie jednak odpowiedniego interfejsu do brania udziału w rozmowach kwalifikacyjnych, więc konieczne będzie stworzenie adaptera. 
             */
        public int ID { get; set; } 
        public string Model { get;  set; }
        public int SerialNumber { get; set; }
        public DateTime ProductionDate{ get;  set; }
        public long ComputingPower { get;set; } //w petalopsach
        public int CoreNumbers { get; set; } 
        public int BatteryLife { get; set; } //w godzinach
        public int DaysNumber
        {
            get
            {
                return (DateTime.Now - ProductionDate).Days;
            }
        }

        public string PodajDane()
        {
            return string.Format("Beep Bop, Jestem {0} {1} Beep Bop.", Model, SerialNumber);
        }

        public string PodajParametry()
        {
            return string.Format("Beep Bop, Posiadam {0} rdzeni, moja wydajnosc wynosi {1} petalopsow i potrafie przepracowac bez ladowania {2} godzin.", CoreNumbers, ComputingPower, BatteryLife);
        }

        public string Powitanie()
        {
            return string.Format("Beep Bop, witaj człowieku, beep bop.");
        }
    }
}
