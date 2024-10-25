using System;

namespace math
{

    class math_pra
    {
        static void Main(string[] args)
        {
            int x = 12;
            int y = 45;
            int z = Math.Max(x, y);
            int min = Math.Min(x, y);
            Console.WriteLine(z);
            Console.WriteLine(min);


            double sq=Math.Sqrt(y);
            Console.WriteLine(sq);

            double ab = -4.3;
            double abs = Math.Abs(ab);
            Console.WriteLine(abs);//{4.3}


            double ro = 9.66;
            double ron = Math.Round(ro);
            Console.WriteLine(ron);//{10}
        }

    }
}