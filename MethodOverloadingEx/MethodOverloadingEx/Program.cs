using System;
using System.Collections.Generic;

namespace MethodOverloadingEx
{
    class Program
    {
        static void Call(int x)
        {
            Console.WriteLine("Call(int x)");
        }
    
        static void Call(double y)
        {
            Console.WriteLine("Call(double y)");
        }
        static void Call(string y)
        {
            Console.WriteLine("Call(string y)"); 
        }

        //Multiparemeters
                static void Call(int x, int y)
                {
                    Console.WriteLine("Call(int x, int y)");  //****if deletes --comment it out to try  ? 
                }

                static void Call(int x, double y)
                {
                    Console.WriteLine("Call(int x, double y)");
                }
        
                static void Call(double x, int y)
                {
                    Console.WriteLine("Call(double x, int y)");
                }

        //Return Type 
        //        static string Call(int x)
        //        {
        //            Console.WriteLine("Call(int x)");
        //            return "";
        //        }
        //
        //        static Guid Call(double y)
        //        {
        //            Console.WriteLine("Call(double y)");
        //            return Guid.Empty;
        //        }

        //optional Paremeters
        //        static void Call(int x, int y = 5)
        //        {
        //            Console.WriteLine("Call(int x, int y = 5)");
        //        }
        //
        //        static void Call(int x, int y = 5, int z = 10)
        //        {
        //            Console.WriteLine("Call(int x, int y = 5, int z = 10)");
        //        }


        //Conversion Availble depending language version
        static void Call(object x)
        {
            Console.WriteLine("Call(object x)");
        }

        static void Call(IEnumerable<object> y)
        {
            Console.WriteLine("Call(IEnumerable<object> y)");
        }



        static void Main(string[] args)
        {
            Call(10); //should return int call because conversion from int to int easier than int to double
            Call("10");//Win base on type.
            Call(5,10);//should return int call because conversion from int to int easier than int to double *****If  deletes Call(int x, int y) compilers returns an error becasue it doesn't know what to pick

            //Inheritance
            ChildCall firstChildCall = new ChildCall();
            firstChildCall.Call(5); //should return call from the child class becasue the compiler consider the target of the call at the compile-time class


            //Inheritance-Override
            firstChildCall.Call(10); //It will return the double method in the child class because the compiler ignores the override.

            //Return types
            //
            //Guid guid = Call(10); //string overload is chosen however the compiler can't assign a string to a Guid


            //Optional parameters
            Call(10); //call the method with the int parameter because the compiler will always pick the methods with less requierements. 
            Call(10); //Ambiguos call compiler do not what to pick becasue there is a tie bewteen methods.

            //name Argument
            Call(y:10);

            //Conversion Availble depending language version
            List<string> strings = new List<string>();
            Call(strings);  //C# 3 AND C# 4 targeting .NET 3.5 will take Call(object x) --- C# 4 targeting .NET 4 will take Call(IEnumerable<T>)

        }
    }
}