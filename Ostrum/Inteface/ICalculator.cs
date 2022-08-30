using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ostrum.Inteface
{
    public interface ICalculator<T, S>
    {
        S GetPrice(T collection);
    }
}
