using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace highestandlowestStockwithencapsulation
{
    public class StockAnalyzer
    {
        private StockDataParser _dataParser;
        public StockAnalyzer(StockDataParser dataparser)
        {
            _dataParser = dataparser;
        }

        public IEnumerable<StockDirection> StockStatus()
        {
            var data = _dataParser.CsvToObjectParser();
            var calculateStock = new CalculateStock(data);
            return calculateStock.StockResults();             
        }
    }
}
