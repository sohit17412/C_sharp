using System;

namespace Oper
{
    class userInput
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter your age");


            // string user = Console.ReadLine();


            //Console.WriteLine("hello " + user);

            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your age is "+ age);// you  cannot get the interger from the input it gives error so you have to convert the given input into int32 by using Convert.ToInt(...).





        }

    }

}