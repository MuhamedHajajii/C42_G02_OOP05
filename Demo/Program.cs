using Demo.Abstractions;
using Demo.ComplexNums;
using Demo.Partials;
using Demo.statics;

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

            /** When we start with web
             * in the mvc specially
             * always will be there a class to sumilate the table in the database
             * and another class will contain the data which i want to store
             */

            // EmployeeViewModel -- Then Change It to EmployeeModel -- Database
            // Database --> Employee --> EmployeeViewModel

            //Employee employee1 = new Employee()
            //{
            //    Id = 1,
            //    FullName = "Aliaa Tarek",
            //    PassWord = "PassWord",
            //    Email = "AliaaTarek@Gmail.com",
            //    SequertyStamp = Guid.NewGuid()
            //};

            //EmployeeViewModel viewModel = new EmployeeViewModel();
            //viewModel = (EmployeeViewModel)employee1;
            //Console.WriteLine( viewModel.FirstName);
            //Console.WriteLine( viewModel.LastName);
            //Console.WriteLine( viewModel.Email);
            //// need to make a casting operator overloading

            //// boxing from value type to reference type and store the value type in the heap
            //// unboxing from reference type to value type and store the refernece type in the stacl
            //// from value type to value type 
            //// from reference type to reference type

            //// the operator of employeeviewmodel is already existed before i override it
            //// i didn't implement this before but already exist before
            //// any defind datatype can transafer data from type object to the datatype
            //// in this case we only ignore the ref of the object
            //// but when i applay the explicit casting it will show the error if i didn't make the casting operator overloading
            //object obj = new EmployeeViewModel();
            //EmployeeViewModel E = (EmployeeViewModel) obj;

            #endregion

            #endregion



            #endregion

            #region 2- Abstract Class 
            // abstraction is like a guid line or a part from the encapsolation
            // we start separate the useless data from class use 

            //Rectangle rectangle = new Rectangle(10,20);

            //decimal RecArea = rectangle.CalcArea();
            //Console.WriteLine(RecArea);

            //Console.WriteLine(rectangle.Perimetere);

            //Circle cirlce = new Circle(30);
            //Console.WriteLine(cirlce.CalcArea());
            //Console.WriteLine(cirlce.Perimetere);

            // can create reference from it 
            // this class must inherit and implement from it
            //Shape shape = new Rectangle(10,20);
            //Console.WriteLine(shape.CalcArea());
            //Console.WriteLine(shape.Perimetere);
            // abstract method abstract constructor abstract property

            // abstract class is mix between two things implemented and not fully implemeted every one of them has his own functionality

            //Rectangle rec = new Rectangle(10, 20);
            //Rectangle.Dim01 = 10; // invalid because its readyonly and can make private too 
            // so i can hide the data whenever i want 

            // the abstract class is a partial implementation for another calss 
            // and the interface is a code contract for the following classes
            // partial implementation for the functions 
            // parital implementation for someparts of the code 
            // i will take the dim01 and dim02 but i don't know what the shape i will calc the area for it 
            #endregion

            #region 3- Static
            // what i can type static class , methods , constructor, property , attribute

            //Utility U01 = new Utility(10,20);
            //Console.WriteLine($"Cm To Inch = {U01.CmToInch(254)}");

            //Utility U02 = new Utility(100, 200);
            //Console.WriteLine($"Cm To Inch = {U01.CmToInch(254)}");

            // if the result of the calling method cmtoinch will not differ
            // by difference of the object state
            // if the method doesn't depend of the object state so i can make it static 

            //Console.WriteLine(Utility.CmToInch(254));

            #endregion

            #region 4- Sealed
            // the documentation in the Sealeds Namespace
            #endregion

            #region 5- Partial

            // separate the code of the same class into two classes in a differnent files
            // the compiler will deal with them as a one file 
            // not like the mapping in the mapping we have two classes with differenct names
            // like model which will represent the table and the viewmodel is the code or viewfor the model
            // in the partial i have two classes with the same name and the compiler will deal with them like one file 
            // because if i conect with the database and change any thing and try to sync the changes from the database the enitiy framework
            // will remove the old file and return a new file so i will not be able to add methods or logic 
            // so i go and make another class with the same name and let the compiler deal with both of them 
            // with the keyword is partial class

            //Employee employee = new Employee();
            //employee.Test = 10;
            // this class is separated to two differenct classes
            #endregion

        } 
    }
}