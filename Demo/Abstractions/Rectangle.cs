using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstractions
{

    abstract class RectBase:Shape
    {
        protected RectBase(decimal dim01, decimal dim02):base(dim01,dim02)
        {
            
        }
        public override decimal CalcArea() => Dim01 * Dim02;

    }


    // between class and class --> inherit
    // between class and interface --> implememnt
    // betweene abstract and class --> inherit and implement both of them
    // rectangle is a fully completed class => implement for the abstract method using override keyword  full class inherit and implement 
    // shape -> abstract class i must inherit it then complete the implementation because it not full class 
    internal class Rectangle : RectBase
    {
        public Rectangle(decimal dim01, decimal dim02) : base(dim01, dim02)
        {
        }



        // because in the Shape we only have get only we can't add set with the get
        // not like the interface we can type what we want 
        public override decimal Perimetere { get  =>  (Dim01 + Dim02) * 2; }

        // you inherit it as abstract you inherit it and override it
        // not like the other override it must be virtual to be able to override it 
        // abstract method override it with the override is mostly like the virtual in the fully class 
    }

    internal class Square : RectBase
    {
        public Square(decimal dim):base(dim,dim)
        {
            Dim01 = Dim02 = dim;
        }
        public override decimal Perimetere => Dim01 * 4;


    }

    class Circle : Shape
    {
        public Circle(decimal Redius):base(Redius,Redius)
        {
            Dim01 = Dim02 = Redius;
        }
        public override decimal Perimetere => 2 * 3.14M * Dim01;

        public override decimal CalcArea()
        {
            return 3.14M * Dim01 * Dim01;
        }
    }

}
