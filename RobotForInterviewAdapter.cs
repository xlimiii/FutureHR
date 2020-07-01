using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureHR
{
    public class RobotForInterviewAdapter : Robot, IJobInterviewInteractions
    {
        /*
         Zastosowałam implementację wzorca poprzez dziedziczenie. Klasa RobotForInterviewAdapter korzysta z metod dostępnych już w klasie Robot jednak posiada interfejs kompatybilny z programem (umożliwi udział w rozmowie o pracę)
             */
        public RobotForInterviewAdapter(Robot r)
        {
            this.Model = r.Model;
            this.SerialNumber = r.SerialNumber;
            this.ProductionDate = r.ProductionDate;
            this.ComputingPower = r.ComputingPower;
            this.CoreNumbers = r.CoreNumbers;
            this.BatteryLife = r.BatteryLife;
        }
        public string PodajImieINazwisko()
        {
            return PodajDane();
        }

        public string PowiedzIleMaszLat()
        {
            return string.Format("Beep Bop, Mam {0} dni czyli {1} lat Beep Bop.", DaysNumber, Convert.ToInt32(DaysNumber/365));
        }

        public string PowiedzOMocnychStronach()
        {
            return PodajParametry();
        }

        public string PrzywitajSie()
        {
            return Powitanie();
        }
    }
}
