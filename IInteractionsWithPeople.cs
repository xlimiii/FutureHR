using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureHR
{
    /*
     IInteractionsWithPeople jest to interfejs implementowany przez klasę Robot. Jest podobny do interfejsu IJobInterviewInteractions, jednak nie taki sam- dlatego będzie potrzeba skorzystania z wzorca Adapter.
         */
    interface IInteractionsWithPeople
    {
        string Powitanie();
        string PodajDane();
        string PodajParametry();
    }
}
