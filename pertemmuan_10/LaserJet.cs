using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pertemmuan_10
{
    public class LaserJet : IPrinterWindows
    {
        public void Print()
        {
            Console.WriteLine("LaserJet printer printing....");
        }

        public void Show()
        {
            Console.WriteLine("LaserJet display dimension : 12*12");
        }
    }
}
