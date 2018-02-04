using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace highestandlowestStockwithencapsulation
{
    public class StockDataParser
    {
        private readonly IFileLoader _dataLoader;

        public StockDataParser(IFileLoader dataloader)
        {
            _dataLoader = dataloader;
        }
        public IList<StockQuoteData> CsvToObjectParser()
        {
            var fileData = _dataLoader.ReadFileData().Split('\n');

            return
                (
                from line in fileData.Skip(1)
                let data = line.Split(',')
                select new StockQuoteData
                {
                    date = DateTime.Parse(data[0], CultureInfo.GetCultureInfo("en-US")),
                    Open = decimal.Parse(data[1]),
                    High = decimal.Parse(data[2]),
                    Low = decimal.Parse(data[3]),
                    Close = decimal.Parse(data[4])
                }
                ).ToList();
        }
    }
}
