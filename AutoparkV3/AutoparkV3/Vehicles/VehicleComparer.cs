using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoparkV3.Vehicles
{
    public class VehicleComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            int result = (x.ModelName).CompareTo(y.ModelName);
            if (result != 0)
            {
                return result;
            }
            else
            {
                return (x.GetTotalProfit()).CompareTo(y.GetTotalProfit());
            }
        }
    }
}
