using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static highestandlowestStockwithencapsulation.StockProgram;

namespace highestandlowestStockwithencapsulation
{
    public class CalculateStock
    {
        private IList<StockQuoteData> _convertedData;
        public CalculateStock(IList<StockQuoteData> converteddata)
        {
            _convertedData = converteddata;
        }

        public IEnumerable<StockDirection> StockResults()
        {
            for (int i = 0; i < _convertedData.Count() - 1; i++)
            {
                if (_convertedData[i].IsStockWentDown(_convertedData[i+1]))
                {
                    yield return new StockDirection(GetDirection.Down, _convertedData[i]);
                }

                if (_convertedData[i].IsStockWentUp(_convertedData[i + 1]))
                {
                    yield return new StockDirection(GetDirection.Up, _convertedData[i]);
                }
            }
            
        }
    }
}
