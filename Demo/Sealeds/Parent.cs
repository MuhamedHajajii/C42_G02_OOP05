using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Sealeds
{
    internal class Parent
    {
        private int salary;

        public virtual int Salary
        {
            get { return salary; }
            set { salary = value + 1000; }
        }

        public virtual void Print()
        {
            Console.WriteLine("I'm Parent");
        }
    }

    class Child : Parent
    {
        // Sealed Method
        // The Other classes will can't overrice on it
        // can be inherited but can't override it anymore 
        public sealed override void Print()
        {
            base.Print();
        }

        public sealed override int Salary 
        { 
            get { return base.Salary; }
            set { base.Salary = value < 5000 ? 5000 : value; }
        }

    }

    sealed class GrandChild : Child
    {
        // can override on it but its will be a new version not related to the preivous versions
        public  new void Print()
        {
            base.Print();
        }
        public new int Salary
        {
            get { return base.Salary; }
            set { base.Salary = value < 5000 ? 5000 : value; }
        }
    }

    //class  test : GrandChild
    //{
            // invalid because i can't inherit from sealed type
    //}
    // overall the sealed stop the heirarchy of something class , property , methods

}
