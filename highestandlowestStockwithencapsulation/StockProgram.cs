using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace highestandlowestStockwithencapsulation
{
    public class StockProgram
    {
        public static void Main(string[] args)
        {
            var getLoader = GetFileLoader(args[0]);
            var stockDataConverter = new StockDataParser(getLoader);
            var stockAnanlyzer = new StockAnalyzer(stockDataConverter);
            foreach (var item in stockAnanlyzer.StockStatus())
            {
                var printstock = new PrintStockStatus(item);
                printstock.PrintStock();
            }

            Console.ReadLine();  
        }
        public static IFileLoader GetFileLoader(string filename)
        {
            IFileLoader _loader;

            if (filename.StartsWith("https"))
            {
                Console.WriteLine("We are still working on this feature. Thank you");
                _loader = null;
            }
            else
            {
                 _loader = new StockDataLoader(filename);
            }

            return _loader;
        }

        public enum GetDirection
        {
            Up = 1,
            Down = 2
        }
    }
}
