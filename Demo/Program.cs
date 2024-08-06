using Demo.ComplexNums;

namespace Demo
{
    internal class Program
    {
        /// Main Topics
        /// 1- Opertator Overloading
        /// 2- Casting Opertator Overloading
        /// 3- Abstrication
        /// 4- Static
        /// 5- Sealed
        /// 6- Partial

        static void Main()
        {
            #region 1- Operator Overloading
            /** Polymorphism [Many Forms]
             * 1- Constructor overloading
             * 2- indexer overloading
             * 3- Method Overloading
             * 4- Operator overloading
             * 5- casting overloading
             * Many Construct or methods or indexer with the same name with new behavior
             * but keep separate them by the number and the type and the sequecne of the type
             */


            #region Overloading Operators

            #region Binary Operator OverLoading
            // complex numbers - real and imaginary
            //ComplexNumss C1 = new ComplexNumss() {Real = 3,Imag = 5};
            //Console.WriteLine(C1); // 3 + 5i

            //ComplexNumss C2 = new ComplexNumss() { Real = 2, Imag = 4 };
            ////ComplexNumss C2 = default;
            //Console.WriteLine(C2);

            //ComplexNumss C3 = C1 + C2; // Invalid Because the plus cannot multiply within two objects 
            //Console.WriteLine(C3); // 5 + 9i
            //// the operator at the end still only a function 
            //// it Must be static a class memeber function can call it from the class and must be public
            //// uniry operators
            //// relational operatora

            //ComplexNumss C4 = C1 - C2;
            //Console.WriteLine(C4);

            //ComplexNumss C5 = new ComplexNumss()
            //{
            //    Real = 3,Imag= 5
            //};
            //C5 += C3;
            #endregion

            #region unary operators
            //ComplexNumss C1 = new ComplexNumss()
            //{
            //    Real = 2 , Imag = 3
            //};
            //ComplexNumss C3 = ++C1;
            //Console.WriteLine(C3);

            //ComplexNumss C1 = new ComplexNumss()
            //{
            //    Real = 2,
            //    Imag = 3
            //};
            //ComplexNumss C3 = --C1;
            //Console.WriteLine(C3);

            //it works even with the postfix or prefix

            #endregion

            #region Relational Operators - [Comparison Operatorts]

            //ComplexNumss C1 = new ComplexNumss()
            //{
            //    Real = 2,Imag = 5
            //};
            //ComplexNumss C2 = new ComplexNumss()
            //{
            //    Real = 2,
            //    Imag = 4
            //};

            //if(C1 > C2)
            //    { Console.WriteLine("C1 Grater Than C2"); }
            //else if (C1 < C2)
            //    { Console.WriteLine("C2 Grater Than C1"); }
            // != and == Comes from the object its works with the reference but if you want to change the behavior you must overload it
            #endregion


            #endregion

            #region Casting operator Overloading

            #region Ex01
            //// boxing from value type to reference type
            //object obj = 2;

            ////explicit casting
            //// unboxing
            //int X = (int) obj;

            //// the casting operator cannot change from userdefind data type to integer
            //ComplexNumss C1 = new ComplexNumss() { Real = 2 , Imag = 4 };
            //int Y = (int)C1;
            ////int Y = C1; // invalid because i make the operator overloading with explicit and it more recomend because the readability
            //Console.WriteLine(Y);

            ////string Name = (string)C1;
            //string Name = C1; // Valid because if i made it implicit it will work in the imlicit and explicit
            //Console.WriteLine(Name);
            #endregion

            #region E02 Mapping Casting Operator Overloading



            #endregion

            #endregion

            #endregion
        }
    }
}