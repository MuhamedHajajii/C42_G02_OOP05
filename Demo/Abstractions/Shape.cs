using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstractions
{
    abstract internal class Shape
    {
        public decimal Dim01 { get; set; }
        public decimal Dim02 { get; set; }

        //automatic proerty with the backing field

        // Can't calc the shape as long as i don't know the shape which will use this function
        // so i will only type the signagture of the method
        // abstract method i don't need its implementation
        // and it should be inside an abstract class because it dosn't include any implementation 
        // so how to creat and use methods inside a class and you doesn't make the implementation 
        // so if the class includes an abstract method it should be abstract class unable to create object from it 
        // partil implementation for another class
        // the same as the interface which i will not able to create object from it 
        // the same as the class but without the ability to create object from it [not fully implemented]
        abstract public decimal CalcArea();

        //public decimal Perimetere { get; } // readonly and will apply the backing field
        abstract public decimal Perimetere { get; } // abstract property
                                                    // with the abstract of the property is the same as the interface property signature

        // we can make a constructor chaining in the abstract class

        protected Shape(decimal dim01,decimal dim02)
        {
            Dim01 = dim01;
            Dim02 = dim02;
        }

    }
}
