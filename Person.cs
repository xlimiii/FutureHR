using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureHR
{
    /*
     Klasa Person odzwierciedla zwykłego człowieka, posiada zaimplementowany interfejs IJobInterviewInteractions, więc może się starać o pracę, ponieważ posiada funkcjonalności pozwalające na przejście rozmowy kwalifikacyjnej. 
         */
    public class Person : IJobInterviewInteractions
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get;  set; }
        public int Age { get; set; }
        public List <string> Feature { get; set; }

        public string PodajImieINazwisko()
        {
            return string.Format("Nazywam się {0} {1}.", FirstName, LastName);
        }

        public string PowiedzIleMaszLat()
        {
            return string.Format("Mam {0} lat.", Age);
            
        }

        public string PowiedzOMocnychStronach()
        {
            string zdanie = "Jestem ";
           for (int i=0; i<Feature.Count-1; i++)
            {
                zdanie += Feature[i];
                zdanie += ", ";
            }
            zdanie = zdanie.Remove(zdanie.Length - 2, 2);
            zdanie += " oraz ";
            zdanie += Feature[Feature.Count - 1];
            zdanie += ".";
            return zdanie;
        }

        public string PrzywitajSie()
        {
           return "Dzien dobry!";
        }
        public override string ToString()
        {
            return String.Format("{0} {1}", FirstName, LastName);
        }
    }
}
