using C42_G02_OOP05.Durations;
using C42_G02_OOP05.FirstProject;
using C42_G02_OOP05.Second_Project;

namespace C42_G02_OOP05
{
    internal class Program
    {
        static void Main()
        {
            #region Q1 - First Project:


            #region  1.	Define 3D Point Class and the basic Constructors (use chaining in constructors). 
            //Done
            #endregion

            #region 2.	Override the ToString Function to produce this output:
            // Point3D P = new Point3D(10, 10, 10);
            // Console.WriteLine(P.ToString());
            // Output: “Point Coordinates: (10, 10, 10)”.

            //Point point01 = new Point(10,10,10);
            //Console.WriteLine(point01.ToString());
            //Console.WriteLine("==========================");
            #endregion

            #region 3.	 Read from the User the Coordinates for 2 points P1, P2 (Check the input using try Pares, Parse, Convert).
            //double X;
            //double Y;
            //Console.Write("Please Enter P1 X Coordinate: ");
            //X = GetValidNumbers();
            //Console.Write("Please Enter P1 Y Coordinate: ");
            //Y = GetValidNumbers();
            //Point p1 = new Point(X,Y);
            //Console.Write("Please Enter P2 X Coordinate: ");
            //X = GetValidNumbers();
            //Console.Write("Please Enter P3 Y Coordinate: ");
            //Y = GetValidNumbers();
            //Point p2 = new Point(X, Y);

            //Console.WriteLine($"P1 is {p1}");
            //Console.WriteLine($"P2 is {p2}");

            #endregion

            #region 4.	Try to use == If(P1 == P2)   Does it work properly? 
            //if (p1 == p2)
            //    Console.WriteLine("Equals");
            //else
            //    Console.WriteLine("Not Equals");

            // it works and check the reference if both have the same reference or not only 
            #endregion

            #region 5.	Define an array of points and sort this array based on X & Y coordinates.
            //Console.Write("Please Enter The Array Size: ");
            //int ArraySize = (int)GetValidNumbers();
            //Point[] Points = new Point[ArraySize];

            //for (int i = 0; i < ArraySize; i++)
            //{
            //    Console.Write($"Enter X Coordinate for Array Number {i + 1}: ");
            //    double X = GetValidNumbers();
            //    Console.Write($"Enter Y Coordinate for Array Number {i + 1}: ");
            //    double Y = GetValidNumbers();
            //    Console.Write($"Enter Z Coordinate for Array Number {i + 1}: ");
            //    double Z = GetValidNumbers();
            //    Points[i] = new Point(X, Y, Z);
            //}

            ////Array.Sort(Points, new Point()); // based on Y 
            //Array.Sort(Points); // based on X 

            //foreach (var item in Points)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 6.	Implement ICloneable interface to be able to clone the object.

            //double X;
            //double Y;
            //Console.Write("Please Enter P1 X Coordinate: ");
            //X = GetValidNumbers();
            //Console.Write("Please Enter P1 Y Coordinate: ");
            //Y = GetValidNumbers();
            //Point p1 = new Point(X, Y);
            //Console.Write("Please Enter P2 X Coordinate: ");
            //X = GetValidNumbers();
            //Console.Write("Please Enter P3 Y Coordinate: ");
            //Y = GetValidNumbers();
            //Point p2 = new Point(X, Y);

            //Console.WriteLine($"P1 is {p1}");
            //Console.WriteLine($"P2 is {p2}");
            //Console.WriteLine("=========================");
            //Console.WriteLine($"P1 is {p1.GetHashCode()}");
            //Console.WriteLine($"P2 is {p2.GetHashCode()}");
            //Console.WriteLine("=========================");

            //Point p3 = (Point) p1.Clone();
            //Console.WriteLine($"P3 is {p3.GetHashCode()}");
            #endregion

            #endregion

            #region Q2 - Second Project:

            // Define Class Maths that has four methods: Add, Subtract, Multiply, and Divide, each of them takes two parameters.Call each method in Main().

            //int Add = Maths.Add(5, 5);
            //int Multiply  = Maths.Multiply(5, 5);
            //int Divide = Maths.Divide(5, 5);
            //int Subtract = Maths.Subtract(5, 5);

            //Console.WriteLine($"Add : {Add}");
            //Console.WriteLine($"Multiply : {Multiply}");
            //Console.WriteLine($"Divide : {Divide}");
            //Console.WriteLine($"Subtract : {Subtract}");


            #endregion

            #region Q3 - Third Project:

            #region 1.	Define Class Duration To include Three Attributes Hours, Minutes and Seconds.
            // Done
            #endregion

            #region 2.	Override All System.Object Members (ToString, Equals,GetHasCode) .
            // Done
            #endregion

            #region 3.	Define All Required Constructors to Produce this output:
            ///Duration D1 = new Duration(1, 10, 15);
            ///D1.ToString();
            ///Output: Hours: 1, Minutes: 10, Seconds: 15
            ///Duration D1 = new Duration(3600);
            ///D1.ToString();
            ///Output: Hours: 1, Minutes: 0, Seconds: 0
            ///Duration D2 = new Duration(7800);
            ///D2.ToString();
            ///Output: Hours: 2, Minutes: 10, Seconds: 0
            ///Duration D3 = new Duration(666);
            ///D3.ToString();
            ///Output: Minutes: 11, Seconds: 6
            ///

            //Duration D1 = new Duration(1, 10, 15);
            //// Hours: 1, Minutes: 10, Seconds: 15
            //Console.WriteLine(D1.ToString());
            //Console.WriteLine("==============================");

            //Duration D2 = new Duration(3600);
            //// Hours: 1, Minutes :0, Seconds :0
            //Console.WriteLine(D2.ToString());
            //Console.WriteLine("==============================");

            //Duration D3 = new Duration(7800);
            //// Hours: 2, Minutes: 10, Seconds: 0
            //Console.WriteLine(D3.ToString());
            //Console.WriteLine("==============================");

            //Duration D4 = new Duration(666);
            //// Hours: 0, Minutes: 11, Seconds: 6
            //Console.WriteLine(D4.ToString());
            //Console.WriteLine("==============================");

            #endregion

            #region 4.	Implement All required Operators overloading to enable this Code:

            Duration D1 = new Duration(1, 10, 15);
            Duration D2 = new Duration(3600);
            Duration D3 = new Duration(666);

            /// ●	D3 = D1 + D2
            ///Duration D3 = D1 + D2;
            ///Console.WriteLine(D1);
            ///Console.WriteLine(D2);
            ///Console.WriteLine(D3);

            /// ●	D3 = D1 + 7800
            ///Duration D3 = D1 + 7800;
            ///Console.WriteLine(D1);
            ///Console.WriteLine(D3);

            /// ●	D3 = 666 + D3
            ///Duration D3 = 666 + D2;
            ///Console.WriteLine(D1);
            ///Console.WriteLine(D3);

            /// ●	D3 = ++D1(Increase One Minute)
            ///Console.WriteLine(D1);
            ///D3 = ++D1;
            ///Console.WriteLine(D3);

            // ●	D3 = --D2(Decrease One Minute)
            ///Console.WriteLine(D2);
            ///D3 = --D2;
            ///Console.WriteLine(D3);

            /// ●	D1 = D1 - D2
            ///Console.WriteLine(D1);
            ///D1 = D1 - D2;
            ///Console.WriteLine(D1);


            // ●	If(D1 > D2)
            //Console.WriteLine(D1);
            //Console.WriteLine(D2);
            //if (D1 > D2)
            //    Console.WriteLine("D2 is greater than D1");
            //else 
            //    Console.WriteLine("D1 is greater than D2");


            // ●	If(D1 <= D2)
            //Console.WriteLine(D1);
            //Console.WriteLine(D2);
            //if (D1 <= D2)
            //    Console.WriteLine("D2 is greater than D1");
            //else
            //    Console.WriteLine("D1 is greater than D2");



            // ●	If(D1)

            //if (D1)
            //    Console.WriteLine("true");
            //else Console.WriteLine("false");

            // ●	DateTime Obj = (DateTime)D1
            //DateTime dt = (DateTime)D1;
            //Console.WriteLine(dt.ToString("HH:mm:ss"));

            #endregion

            #endregion

        }

        #region Global Methods
        public static double GetValidNumbers()
        {
            bool Flag;
            do
            {
                Flag = double.TryParse(Console.ReadLine(), out double Coordinate);
                if (Flag)
                {
                    return Coordinate;
                }
            } while (!Flag);
            return 0;
        }
        #endregion

    }
}
