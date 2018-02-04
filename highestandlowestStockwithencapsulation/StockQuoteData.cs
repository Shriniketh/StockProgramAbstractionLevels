using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace highestandlowestStockwithencapsulation
{
    public class StockQuoteData
    {
        public DateTime date { get; set; }

        public decimal High { get; set; }

        public decimal Low { get; set; }

        public decimal Open { get; set; }

        public decimal Close { get; set; }

        public bool IsStockWentDown(StockQuoteData quote)
        {
            return (Open > quote.High && Close < quote.Low);
        }

        public bool IsStockWentUp(StockQuoteData quote)
        {
            return (Open < quote.Low && Close > quote.High);
        }

    }
}
