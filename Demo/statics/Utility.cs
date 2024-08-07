using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.statics
{
    static internal class Utility
    {
        // Helper Class and container for some utilities i will use in the future

        //public int X { get; set; }
        //public int Y { get; set; }

        //public Utility(int x, int y)
        //{
        //    X = x;
        //    Y = y;
        //    // is not the place to init this here
        //    //Pi = 3.14;
        //}
        // class member constructor 
        // static constructor special constructor 
        // maximum the class conatin only on
        // no access modifier 
        // not able to be called 
        // execute for only one time 
        // before any use of the class
        // if you try to access this class in any way this class member constructor will be fire
        // used for initialize the static members fields
        // so if you want to make a static fields use the class constructor
        static Utility(){
            pi = 3.14;
            }

        //public override string ToString()
        //{
        //    return $"X = {X} , Y = {Y}";
        //}

        // function transafre from cm to inch
        // object member function [non static function]
        
        // class member method static method doesn't depend on the object state 
        static public double CmToInch(double cm)
        {
            return cm / 2.54;
        }
        private const double bi = 3;
        // object member method must called from object from the class
        // object member attribute 
        // compoiler intialize the static attribute with the default value of the datatype [0]
        static private readonly double pi = 3.14;
        // object member property
        static public double Pi
        {
            get { return pi; }
            //set { pi = value; }
        }
        static public double CalcCircleArea(double R)
        {
            // pi is a object member property
            // object member property can not be used inside static method
            //Utility U01 = new Utility(10, 20);
            //return U01.Pi * R * R;
            return Pi * R * R;
        }

    }
}
