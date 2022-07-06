using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todeb_Ikinci_Odev
{
    class SquareClass : AbstractClass
    {
        private int side;

        public SquareClass(int x = 0)
        {
            side = x;
        }
        public override int calculateArea()
        {
            Console.Write("Karenin Alanı: ");
            return (side * side);
        }
    }
}
