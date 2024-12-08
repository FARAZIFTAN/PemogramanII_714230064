using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714230064
{
    public class DVD_714230064 : Product_714230064
    {
        protected string duration;
        public DVD_714230064(string title, string duration) : base(duration,title)
        {
            MyType = "DVD";
            //MyTitle = title;
            this.duration = duration;
            Console.WriteLine("Ini dari class DVD");
        }

        public string Duration
        {
            get { return duration; }
            set {duration = value;}

        }
        //implementasi metode abstrak 
        public override void DisplayInfo()
        {
            Console.WriteLine("Product is a {0} called \"{1}\" and has {2} minutes duration", MyType, MyTitle, Duration);
        }
    }
}
