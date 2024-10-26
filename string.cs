using System;

namespace strin
{
    class stri
    {
        static void Main(string[] args)
        {
            /***Interpolation*/
            string name = "Prashant";
            string sirname = "Verma";

            string fullname=$"Hello the developer name is {name} {sirname}";

            Console.WriteLine(fullname);

            /**********************************************************/

            // access string characters

            char ch = name[2];
            Console.WriteLine(ch);//{a}

            int ind = name.IndexOf('s');
            Console.WriteLine(ind);


            // concatination.

            string a1 = "hello";
            string a2= "mate your program is  working";

            Console.WriteLine(a1 + a2);

            

        }
    }
}