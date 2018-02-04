using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static highestandlowestStockwithencapsulation.StockProgram;

namespace highestandlowestStockwithencapsulation
{
    public class PrintStockStatus
    {
        private StockDirection _direction;
        public PrintStockStatus(StockDirection direction)
        {
            _direction = direction;
        }

        public void PrintStock()
        {
            if (_direction.Direction == GetDirection.Down)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The Stock prices went down on {0}", _direction.Quote.date.ToShortDateString());
            }

            if (_direction.Direction == GetDirection.Up)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The Stock prices went up on {0}", _direction.Quote.date.ToShortDateString());
            }
        }
        }
    }
