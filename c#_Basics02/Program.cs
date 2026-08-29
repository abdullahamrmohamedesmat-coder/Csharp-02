using System.ComponentModel;
using System;
using System.Dynamic;
using System.Globalization;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.Marshalling;
using System.Threading;
using System.Xml;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Book
           

            object obj01 = new Book { Title = "C#", Pages = 133 };

            object obj02 = new Book { Title = "C#", Pages = 133 };

            Console.WriteLine(obj01);
            Console.WriteLine(obj01.ToString());
            Console.WriteLine(obj01.Equals(obj02));
            Console.WriteLine(obj01.GetHashCode());
            Console.WriteLine(obj02.GetHashCode());
            Console.WriteLine(obj01.GetType());

            #endregion
            #region compile error
            //  Look at the line below.Is it a compile-time error, a runtime error, or a logical error? Fix it.
            //int pages = "464";
            // Compile - time error — you can't put text (string) into an int variable. 
            //int pages = 464; 
            #endregion
            //2st answer
            #region Try
            //Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by zero", and then prints "Done" in a finally block.

            try
            {
                int x = 10;
                int y = 0;
                int result = x / y;
                Console.WriteLine(result);


            }
            catch (Exception e)
            {
                Console.WriteLine("you cannot divided by zero");

            }
            finally
            {
                Console.WriteLine("Done");
            }
            #endregion
            //3st answer 
            #region declare with cast
            //Declare an int pages = 300; then store it in a double variable without using a cast.


            int pages = 300;
            double p = pages;
            #endregion
            // 4st answer
            #region declare with cast
            //Declare a double price = 49.99; then convert it into an int using a cast.

            double price = 49.99;
            int r = (int)price;
            #endregion
            //5st answer
            #region Conver class
            //Given string pagesText = "464";, convert it into an int using the Convert class.

            string pagesText = "464";
            int c = Convert.ToInt32(pagesText);
            #endregion

            #region Parse vs tryParse
            //Given string yearText = "2023";, convert it using int.Parse().Then given string badText = "abc";, use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.

            string yearText = "2023";
            int i = int.Parse(yearText);

            string badText = "abc";
            int result02;
            int.TryParse(badText, out result02);

            if (result02 == 0)
            {
                Console.WriteLine("invaild number");
            }
            else
            {
                Console.WriteLine("vaild number");
            }
            #endregion

            #region Tostring
            //Given int pages = 464;, convert it into a string using ToString() and print its type using GetType() to prove it's now a string.

            int pages02 = 464;
            string z = pages02.ToString();
            Console.WriteLine(z);
            Console.WriteLine(z.GetType());
            #endregion

            #region Boxing and unboxing 
            //Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int variable, and print both.
            int boxcopies = 100;
            object obj = boxcopies;
            int unboxcopies = (int)obj;
            Console.WriteLine($"boxed value is {obj}");
            Console.WriteLine($"unnboxed value is {unboxcopies}");

            #endregion

        }
    }
}