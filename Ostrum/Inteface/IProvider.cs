using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ostrum
{
    public interface IProvider
    {
        List<decimal> GetPrices();
    }
}
