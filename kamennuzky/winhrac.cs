using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kamennuzky
{
    internal class winhrac
    {
        public void WinHrac()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Máš bod");
            Console.ResetColor();
        }
        public void WinBot()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("nepřítel má bod");
            Console.ResetColor();
        }
    }   
}
