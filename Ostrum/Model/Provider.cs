using Ostrum.Inteface;

namespace Ostrum.Model
{
    public class Provider : IProvider
    {
        public List<decimal> Prices { get; set; }

        public Provider()
        {
            Prices = new List<decimal>()
            {
                new decimal(12.5),
                new decimal(14.3),
                new decimal(95.7),
                new decimal(78),
                new decimal(10)
            };
        }

        public List<decimal> GetPrices()
        {
            return Prices;
        }
    }
}
