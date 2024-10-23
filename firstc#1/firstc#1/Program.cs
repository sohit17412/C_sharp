using System;
using System.Runtime.CompilerServices;//using System means that we can use classes from the System namespace.

namespace HelloWorld //namespace is used to organize your code, and it is a container for classes and other namespaces.
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string nam = "Prashu";
            int num = 133;
            double num1 = 0.253;
            char n = 'D';
            bool condi = true;
            const int nop = 44;// now it will become constant it cannot change.
            Console.WriteLine(nop);
            Console.WriteLine(condi);
            Console.WriteLine(n);
            Console.WriteLine(num1);
            Console.WriteLine(nam);
            Console.WriteLine(num);


            Console.WriteLine("Hello Prashant you did it your first test program");// Console is a class of the System namespace, which has a WriteLine() method that is used to output/print text. In our example, it will output "Hello Prashant you did it your first test program".

            // If you omit the using System line, you would have to write System.Console.WriteLine() to print/output text.


            /******************************************************************************************/
            // Type Casting.
            /*Type casting is when you assign a value of one data type to another type.

            In C#, there are two types of casting:

            Implicit Casting (automatically) - converting a smaller type to a larger type size
            char -> int -> long -> float -> double

            Explicit Casting (manually) - converting a larger type to a smaller size type
            double -> float -> long -> int -> char


            */

            // Implicit Casting(automatically)
            int imo = 44;
            double dou = imo;
            Console.WriteLine(dou);

            int tape = 22;
            string str= "gola";
            double top = 12.35;
            bool cond= false;
          Convert.ToDouble(tape);
           /// Console.WriteLine(Convert.ToString(cond));// converted into string automatically.
           Console.WriteLine(tape);
            Console.WriteLine(top);

            // Explicit manually.
            Console.WriteLine(top);
            int conv = (int)top;
            Console.WriteLine(conv);
            /*******************************************************************/
            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string


        }
    }
}