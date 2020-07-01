using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureHR
{
    /*
     Jest to pożądany przez nas interfejs, który powinien być implementowany przez klasę Person oraz klasę Robot. Taki interfejs umożliwi przeprowadzenie symulacji rozmowy kwalifikacyjnej. Interfejs został stworzony dawno temu z myślą, że tylko ludzie będą z niego korzystać. Teraz, gdy o pracę ubiegają się również roboty interfejs nie jest kompatybilny z klasą Robot, konieczne będzie skorzystanie z Adaptera. 
         */
    public interface IJobInterviewInteractions
    {
        string PrzywitajSie();
        string PodajImieINazwisko();
        string PowiedzIleMaszLat();
        string PowiedzOMocnychStronach();
    }
}
