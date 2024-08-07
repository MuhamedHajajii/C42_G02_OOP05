using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_OOP05.Second_Project
{
    public static class Maths
    {
        public static int Add(int? A , int? B)
        {
            return (A ?? 0) + (B ?? 0);
        }
        public static int Subtract(int? A, int? B)
        {
            return (A ?? 0) - (B ?? 0);
        }
        public static int Multiply(int? A, int? B)
        {
            return (A ?? 0) * (B ?? 0);
        }
        public static int Divide(int? A, int? B)
        {
            return (A ?? 0) / (B != 0 ? (B ?? 0) : 0);
        }
    }
}
