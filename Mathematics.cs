using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestOfArray
{
    /*
    Programmer: Ashley (Ian Lawton).
    Date: 3/21/2018.
    This is a basic but hopefully useful class that can calculate: Square roots, cube roots, and quadratic values.
    Here are instructions on use.
    Quadratics:
    There are two quadratic functions for both the normal and the fast implementations (the normal being optimized 
    for precision to one ten thousandth, and the fast more so meant for quick and innaccurate calculations).
    The  "pos and the "neg" names refer to the fact that the quadratic has two outputs, 
    (note the -b plus OR minus the square root of b squared minus 4*a*c) meaning that a method would have to 
    return TWO values (which isn't feasible at the moment. I may fix this so that they are outputed in an array
    later from a single method.
    usage is as follows:
    Mathematics.negQuadratic(1, 70, 3)
    //the three values being a,b,c in that order in the quadratic formula.
    //It is similar with the fastNegQuadratic and the fastPosQuadratic. 
    //For repeated use within a program, I advise creating a void method that writes to the console both outputs.
    square:
    Mathematics.square(3);
    //provided within the parentheses.
    //and holy crap don't use two different data types for the quadratics. I created overloaded methods so they
    //will do either all int or all double.
    */
    class Mathematics
    {
        public Mathematics()
        {

        }

        public static double square(double a)
        {
            for (int i = 0; i < 1; i++)
            {
                a *= a;
            }
            return a;
        }
        public static int square(int a)
        {
            for (int i = 0; i < 1; i++)
            {
                a *= a;
            }
            return a;
        }
        private static double squareRootForQuad(double a, double b = 0)
        {
            while (square(b) < a)
            {
                
                if (square(b) < a - .000001)
                {
                    b += .00001;
                }
                else if (square(b) < a - .00001)
                {
                    b += .0001;
                }
                else if (square(b) < a - .0001)
                {
                    b += .001;
                }
                else if (square(b) < a - .001)
                {
                    b += .01;
                }
                else if (square(b) < a - .01)
                {
                    b += .1;
                }
                else if (square(b) < a - 1)
                {
                    b += 1;
                }
                else if (square(b) < a - 10)
                {
                    b += 10;
                }
                else if (square(b) < a - 100)
                {
                    b += 100;
                }
            }
            return b;
        }
        private static double squareRootForQuad(int a, double b = 0)
        {
            while (square(b) < a)
            {

                if (square(b) < a - .000001)
                {
                    b += .00001;
                }
                else if (square(b) < a - .00001)
                {
                    b += .0001;
                }
                else if (square(b) < a - .0001)
                {
                    b += .001;
                }
                else if (square(b) < a - .001)
                {
                    b += .01;
                }
                else if (square(b) < a - .01)
                {
                    b += .1;
                }
                else if (square(b) < a - 1)
                {
                    b += 1;
                }
                else if (square(b) < a - 10)
                {
                    b += 10;
                }
                else if (square(b) < a - 100)
                {
                    b += 100;
                }
            }
            return b;
        }
        public static double cube(double a)
        {
            for (int i = 0; i < 1; i++)
            {
                a *= square(a);
            }
            return a;
        }
        public static double cube(int a)
        {
            for (int i = 0; i < 1; i++)
            {
                a *= square(a);
            }
            return a;
        }
        public static double squareRoot(double a, double b = 0)
        {
            while (square(b) < a)
            {
                b += .001;
            }
            return b;
        }
        public static double squareRoot(int a, double b = 0)
        {
            while (square(b) < a)
            {
                b += .001;
            }
            return b;
        }
        public static double fastSquareRoot(double a, double b = 0)
        {
            while (square(b) < a)
            {
                b += .01;
            }
            return b;
        }
        public static double fastSquareRoot(int a, double b = 0)
        {
            while (square(b) < a)
            {
                b += .01;
            }
            return b;
        }
        public static double fastCubeRoot(double a, double b = 0)
        {
            while (cube(b) != a)
            {
                b += .01;
            }
            return b;
        }
        public static double fastCubeRoot(int a, double b = 0)
        {
            while (cube(b) != a)
            {
                b += .01;
            }
            return b;
        }
        public static double cubeRoot(double a, double b = 0)
        {
            while (cube(b) < a)
            {
                
                if (square(b) < a - .0001)
                {
                    b += .001;
                }
                else if (square(b) < a - .001)
                {
                    b += .01;
                }
                else if (square(b) < a - .01)
                {
                    b += .1;
                }
                else if (square(b) < a - 1)
                {
                    b += 1;
                }
                else if (square(b) < a - 10)
                {
                    b += 10;
                }
            }
            return b;
        }
        public static double cubeRoot(int a, double b = 0)
        {
            while (cube(b) < a)
            {

                if (square(b) < a - .0001)
                {
                    b += .001;
                }
                else if (square(b) < a - .001)
                {
                    b += .01;
                }
                else if (square(b) < a - .01)
                {
                    b += .1;
                }
                else if (square(b) < a - 1)
                {
                    b += 1;
                }
                else if (square(b) < a - 10)
                {
                    b += 10;
                }
            }
            return b;
        }
        public static double posQuadratic(double a, double b, double c)
        {
            double x = 0;
            double outsideForm = -b;
            double bottomForm = 2 * a;
            if ((square(b) - (4 * a * c)) >= 0)
            {
                return (outsideForm + (squareRootForQuad(square(b) - (4 * a * c)))) / bottomForm;
            }
            else if ((square(b) - (4 * a * c)) < 0)
            {
                return null;
            }
            return x;
        }
        public static double posQuadratic(int a, int b, int c)
        {
            double x = 0;
            double outsideForm = -b;
            double bottomForm = 2 * a;
            if ((square(b) - (4 * a * c)) >= 0)
            {
                return (outsideForm + (squareRootForQuad(square(b) - (4 * a * c)))) / bottomForm;
            }
            else if ((square(b) - (4 * a * c)) < 0)
            {
                return null;
            }
            return x;
        }
        public static double negQuadratic(double a, double b, double c)
        {
            double x = 0;
            double outsideForm = -b;
            double bottomForm = 2 * a;
            if ((square(b) - (4 * a * c)) >= 0)
            {
                return (outsideForm - (squareRootForQuad(square(b) - (4 * a * c)))) / bottomForm;
            }
            else if ((square(b) - (4 * a * c)) < 0)
            {
                return null;
            }
            return x;
        }
        public static double negQuadratic(int a, int b, int c)
        {
            double x = 0;
            double outsideForm = -b;
            double bottomForm = 2 * a;
            if ((square(b) - (4 * a * c)) >= 0)
            {
                return (outsideForm - (squareRootForQuad(square(b) - (4 * a * c)))) / bottomForm;
            }
            else if ((square(b) - (4 * a * c)) < 0)
            {
                return null;
            }
            return x;
        }
        public static double fastPosQuadratic(double a, double b, double c)
        {
            double x = 0;
            double outsideForm = -b;
            double bottomForm = 2 * a;
            if ((square(b) - (4 * a * c)) >= 0)
            {
                return (outsideForm + (squareRoot(square(b) - (4 * a * c)))) / bottomForm;
            }
            else if ((square(b) - (4 * a * c)) < 0)
            {
                return null;
            }
            return x;
        }
        public static double fastPosQuadratic(int a, int b, int c)
        {
            double x = 0;
            double outsideForm = -b;
            double bottomForm = 2 * a;
            if ((square(b) - (4 * a * c)) >= 0)
            {
                return (outsideForm + (squareRoot(square(b) - (4 * a * c)))) / bottomForm;
            }
            else if ((square(b) - (4 * a * c)) < 0)
            {
                return null;
            }
            return x;
        }
        public static double fastNegQuadratic(double a, double b, double c)
        {
            double x = 0;
            double outsideForm = -b;
            double bottomForm = 2 * a;
            if ((square(b) - (4 * a * c)) >= 0)
            {
                return (outsideForm - (squareRoot(square(b) - (4 * a * c)))) / bottomForm;
            }
            else if ((square(b) - (4 * a * c)) < 0)
            {
                return null;
            }
            return x;
        }
        public static double fastNegQuadratic(int a, int b, int c)
        {
            double x = 0;
            double outsideForm = -b;
            double bottomForm = 2 * a;
            if ((square(b) - (4 * a * c)) >= 0)
            {
                return (outsideForm - (squareRoot(square(b) - (4 * a * c)))) / bottomForm;
            }
            else if ((square(b) - (4 * a * c)) < 0)
            {
                return null;
            }
            return x;
        }
        public static void quadratic(int a, int b, int c)
        {
            Console.WriteLine(negQuadratic(a, b, c) + " " + posQuadratic(a, b, c));
        }
        public static void quadratic(double a, double b, double c)
        {
            Console.WriteLine(negQuadratic(a, b, c) + " " + posQuadratic(a, b, c));
        }

    }
}
