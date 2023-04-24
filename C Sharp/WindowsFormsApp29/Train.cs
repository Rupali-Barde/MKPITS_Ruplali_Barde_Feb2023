using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp29
{
    abstract class Train
    {
        public string TrainName { get; set; }
        public string Source { get; set;}
        public string Drestination { get; set;}
        public abstract  string CalculatePay();

        class Passenger : Train
        {
            public string Name { get; set; }
            public int Age { get; set; }    
            public string Address { get; set; } 

            public double PhoneNo { get; set; }
            public string TrainName { get;set; }




    }
}
