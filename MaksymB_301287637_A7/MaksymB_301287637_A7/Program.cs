using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MaksymB_301287637_A7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DivisionNoHandling();
            DivisionWithExceptionHandling();
            DivisionWithExceptionHandlingMoreInfo();
            DivisionWithExceptionHandlingThrow();
            GeneratingException();
            HandlingRandomException();
            Console.WriteLine("end of program");
        }
        static int Division(int top, int bottom)
        {
            return top / bottom;
        }
        static void DivisionNoHandling()
        {
            //call the Division method with argument 1 and 0
            //this will terminate your application
            Division(1, 0);
        }

        static void DivisionWithExceptionHandling()
        {
            //call the Division method with argument 1 and 0
            //You will catch the exception and do nothing
            //Your application should not crash
            try
            {
                Division(1, 0);
            }
            catch (System.DivideByZeroException e)
            {
            }
        }

        static void DivisionWithExceptionHandlingMoreInfo()
        {
            //call the Division method with argument 1 and 0
            //You will catch the exception and print the associated message
            //your application should not crash
            try
            {
                Division(1, 0);
            }
            catch (System.DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void DivisionWithExceptionHandlingThrow()
        {
            //call the Division method with argument 1 and 0
            //You will catch the exception and print the associated message
            //You should create and throw a new exception
            //your application will crash
            try
            {
                Division(1, 0);
            }
            catch (System.DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            throw new Exception("Stop dividing by Zero!");
        }

        static void GeneratingException()
        {
            //You should create and throw a new exception
            //your application will crash
            throw new Exception("That is a bad idea to use this function");
        }


        static void HandlingRandomException()
        {
            //You should call the method below and catch all the possible exceptions individually and display a sensible output
            //your application will not crash
            try
            {
                GeneratingRandomException();
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (OutOfMemoryException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void GeneratingRandomException()
        {
            int exceptionType = new Random().Next() % 6;
            switch (exceptionType)
            {
                case 0:
                    throw new IndexOutOfRangeException();
                case 1:
                    throw new NullReferenceException();
                case 2:
                    throw new InvalidOperationException();
                case 3:
                    throw new ArithmeticException();
                case 4:
                    throw new FormatException();
                case 5:
                    throw new InvalidCastException();
                case 6:
                    throw new OutOfMemoryException();
            }

        }

    }
}

