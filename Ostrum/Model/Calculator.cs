using Ostrum.Inteface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ostrum.Model
{
    public class Calculator :  ICalculator<List<decimal>, decimal> , ICalculator<List<List<decimal>>, decimal>
    {

        public decimal GetPrice(List<List<decimal>> collection)
        {
            List<decimal> list = new List<decimal>();
            foreach (var item in collection)
            {
                list.Add(item.Average());
            }
            return list.Average();
        }

        public decimal GetPrice(List<decimal> collection)
        {
            return collection.Average();
        }
    }
}
