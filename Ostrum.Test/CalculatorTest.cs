using Moq;
using Ostrum.Inteface;
using Ostrum.Model;

namespace Ostrum.Test
{
    public class CalculatorTest
    {

        private readonly ICalculator<List<List<decimal>>, decimal> _calculatorList;
        private readonly ICalculator<List<decimal>, decimal> _calculator;

        private readonly OrchestrePrice _orchestrePrice;

        private readonly List<decimal> Prices;
        private readonly List<List<decimal>> PricesList;

        public CalculatorTest()
        {
            _calculatorList = new Calculator();
            _calculator = new Calculator();
            _orchestrePrice = new OrchestrePrice(_calculatorList, _calculator) ; //_calculatorList.Object,

            Prices = new List<decimal>()
            {
                new decimal(12.5),
                new decimal(14.3),
                new decimal(95.7),
                new decimal(78),
                new decimal(10)
            };

            PricesList = new List<List<decimal>>
            {
                new List<decimal>()
                {
                    new decimal(12.5),
                    new decimal(14.3),
                    new decimal(95.7),
                    new decimal(78),
                    new decimal(10)
                },

                new List<decimal>()
                {
                    new decimal(19.5),
                    new decimal(7.3),
                    new decimal(2.7),
                    new decimal(8),
                    new decimal(18)
                },

                new List<decimal>()
                {
                    new decimal(14.5),
                    new decimal(6.3),
                    new decimal(81.7),
                    new decimal(48),
                    new decimal(14)
                }

            };

        }

        [Fact]
        public void AverageListofDecimalTest()
        {
            //Assert
            decimal expected = 42.1m;

            //Act
            var avgPrice = _orchestrePrice.GetAvg(Prices);

            //Arrange
            Assert.Equal(expected, avgPrice);
        }

        [Fact]
        public void AverageListofLisDecimalTest()
        {
            //Assert
            decimal expected = 28.7m;
            
            //Act
            var avgPrice = _orchestrePrice.GetAvgList(PricesList);

            //Arrange
            Assert.Equal(expected, avgPrice);
        }
    }
}