using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714230064
{
    public class Book_714230064 : Product_714230064
    {
        protected string pageCount;
        public Book_714230064(string type, string title, string pagecount): base (type, title)
        {
            this.pageCount = pagecount;
        }

        public string PageCount
        {
            get { return pageCount; }
            set { pageCount = value; } 
        }

        //Implementasi metode abstrak 
        public override void DisplayInfo()
        {
            Console.WriteLine("Product is a {0} called \"{1}\" and has {2} pages", MyType, MyTitle, PageCount); 
        }
    }
}
