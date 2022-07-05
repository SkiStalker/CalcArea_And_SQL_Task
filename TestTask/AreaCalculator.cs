using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    static public class AreaCalculator
    {
        public static double CalcArea(params double[] args)
        {
            if (args.Length == 1)
            {
                return CalcCircleArea(args[0]);
            }
            else if (args.Length == 3)
            {
                return CalcTriangleArea(args[0], args[1], args[2]);
            }
            else
            {
                throw new ArgumentException("Incorrect count of args");
            }
        }
        public static double CalcCircleArea(double r)
        {
            if (r < 0)
                throw new ArgumentException("Radius less than 0");

            return Math.PI * r * r;
        }

        public static double CalcTriangleArea(double a, double b, double c)
        {
            if (!TriangleIsExist(a, b, c))
                throw new ArgumentException("Triangle has not exist");

            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        static bool TriangleIsExist(double a, double b, double c)
        {
            if ((a < 0) || b < 0 || c < 0)
                throw new ArgumentException("Triangle side less than 0");

            return ((a + b) > c) && ((a + c) > b) && ((b + c) > a);
        }

        public static bool IsRightTriangle(double a, double b, double c)
        {
            if (!TriangleIsExist(a, b, c))
                throw new ArgumentException("Triangle has not exist");

            if (a < c)
            {
                (a, c) = (c, a);
            }
            else if (a < b)
            {
                (a, b) = (b, a);
            }

            return b * b + c * c == a * a;
        }
    }
}
