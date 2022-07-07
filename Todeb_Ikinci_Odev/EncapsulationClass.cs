using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todeb_Ikinci_Odev
{
    class EncapsulationClass
    {
        private string shapeName { get; set; }
        public string shapeCorner { get; set; }

        //CONSTRUCTOR
        public EncapsulationClass(string shapeName, string shapeCorner)
        {
            this.shapeName = shapeName;
            this.shapeCorner = shapeCorner;
            Console.WriteLine($"Şeklin Adı: {this.shapeName}\nŞeklin Kenar Sayısı: {this.shapeCorner}");
        }
    }
}
