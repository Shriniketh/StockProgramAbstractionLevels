using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static highestandlowestStockwithencapsulation.StockProgram;

namespace highestandlowestStockwithencapsulation
{
    public class StockDirection
    {
        public GetDirection Direction { get; set; }

        public StockQuoteData Quote { get; set; }
        public StockDirection(GetDirection direction, StockQuoteData quote)
        {
            Direction = direction;

            Quote = quote;
        }
    }
}
