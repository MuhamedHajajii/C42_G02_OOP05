using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.ComplexNums
{
    internal class ComplexNumss
    {
        public int Real { get; set; }
        public int Imag { get; set; }

        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }

        public static ComplexNumss operator +(ComplexNumss Left , ComplexNumss Right)
        {
            return new ComplexNumss()
            {
                // if there any value of the right and the left == null when it start propagate it may == null 
                // null coalesecing operator works after the plus operator
                Real = (Left?.Real ?? 0) + (Right?.Real ?? 0),
                Imag = (Right?.Imag ?? 0) + (Left?.Imag ?? 0),
            };
        }

        public static ComplexNumss operator -(ComplexNumss Left, ComplexNumss Right)
        {
            return new ComplexNumss()
            {
                Real = (Left?.Real ?? 0) - (Right?.Real ?? 0),
                Imag = (Left?.Imag ?? 0) - (Right?.Imag ?? 0)
            };
        }

    }
}
