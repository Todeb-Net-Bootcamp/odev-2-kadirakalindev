using System;

namespace Todeb_Ikinci_Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            // ENCAPSULATIN ORNEGI
            EncapsulationClass encClass = new EncapsulationClass("Kare","4");

            //ABSTRACT CLASS VE OVERRİTE ÖRNEĞİ
            SquareClass absClass = new SquareClass(4);
            double result = absClass.calculateArea();

            Console.Write("{0}", result);
        }
    }
}
