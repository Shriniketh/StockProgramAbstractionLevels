using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace highestandlowestStockwithencapsulation
{
   public class StockDataLoader : IFileLoader
    {
        private readonly string _filename;
        public StockDataLoader(string filename)
        {
            _filename = filename;
        }

        public string ReadFileData()
        {
            return File.ReadAllText(_filename); 
        }
    }
}
