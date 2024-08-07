using Demo.Sealeds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Partials
{
    internal partial class Employee : Parent
    {
        public override void Print()
        {
            Console.WriteLine("I'm Employee");
        }
        public int Test { get; set; }

        public partial void Tests()
        {
            Console.WriteLine();
        }

    }
    internal partial class Employee : Parent
    {
        public void Prindt()
        {
            Console.WriteLine("I'm Employee");
        }
        public int Tesdt { get; set; }
        //public partial void Tests()
        //{
        //    Console.WriteLine();
        //}
    }
}
