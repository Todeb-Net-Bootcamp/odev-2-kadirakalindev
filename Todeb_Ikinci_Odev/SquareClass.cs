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

        //CONSTRUCTOR
        public SquareClass(int x = 0)
        {
            side = x;
        }
        //ABSTRACT METOD OVERRİDE EDİLDİ
        public override int calculateArea()
        {
            Console.Write("Karenin Alanı: ");
            return (side * side);
        }
    }
}
