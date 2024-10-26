using System;
namespace boolpractice
{
    class boole
    {
        static void Main(string[]args)
        {
            int x = 21;
            int y = 56;

            Console.WriteLine(x > y);// it gives the output in boolen form {false}
            Console.WriteLine(x<y);// {true}

            /****/


            if (x >= y)
            {
                Console.WriteLine($"{x} is small");

            }
            else
            {
                Console.WriteLine($"{y} is large");
            }


            /**/

            Console.WriteLine(10 == 15); // returns False, because 10 is not equal to 15
        }
    }
}