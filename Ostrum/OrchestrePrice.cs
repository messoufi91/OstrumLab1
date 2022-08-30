using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ostrum.Inteface;

namespace Ostrum
{
    public class OrchestrePrice
    {
        private readonly ICalculator<List<List<decimal>>, decimal> _calculatorList;
        private readonly ICalculator<List<decimal>, decimal> _calculator;

        public OrchestrePrice(ICalculator<List<List<decimal>>, decimal> calculatorList,
            ICalculator<List<decimal>, decimal> calculator)
        {
            _calculatorList = calculatorList;
            _calculator = calculator;
        }

        public decimal GetAvg(List<decimal> Prices)
        {
            return _calculator.GetPrice(Prices);
        }

        public decimal GetAvgList(List<List<decimal>> Prices)
        {
            return _calculatorList.GetPrice(Prices);
        }

    }
}
