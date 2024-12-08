using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714230064
{
         class ProductTest_714230064
    {
        static void Main(string[] args)
        {
            //Product_714230064 myProduct = new Product_714230064();
            //myProduct.MyType = "DVD";

            //Console.WriteLine(myProduct.myType);

            Book_714230064 product1 = new Book_714230064("Book", "C# Object Oriented Solution", "300");
            DVD_714230064 product2 = new DVD_714230064("Ethernal Shunshine Of The Spotless Mind", "145");
            product1.DisplayInfo();
            product2.DisplayInfo();
        }
    }
}
