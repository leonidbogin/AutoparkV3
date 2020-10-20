using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoparkV3
{
    public class Rent
    {
        public DateTime Date { get; set; }
        public double RentCost { get; set; }

        public Rent()
        {

        }

        public Rent(DateTime date, double rentCost)
        {
            Date = date;
            RentCost = rentCost;
        }
    }
}
