using System;

namespace AverageNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Да се въведе n естествено число, кратно на 4. Да се изведат числата от 1 до n по начините от предишната задача. 
                Направете контрол при въвеждане на n.

                стр. 126р зад.212
             */
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            if (n % 4 == 0)
            {
                for (int i = 1; i <= n; i++)
                    Console.Write(i + " ");
                Console.WriteLine();
                Console.WriteLine();

                for (int i = 1; i >= n; i--)
                    Console.Write(i + " ");
                Console.WriteLine();
                Console.WriteLine();


                for (int i = 1; i <= 50; i++)
                    Console.Write(i + " " + (n - i + 1) + " ");
                Console.WriteLine();
                Console.WriteLine();

                for (int i = 1; i <= n; i++)
                    if (i % 2 != 0) ;

                    else Console.Write((n - i + 2) + " " + (n - i + 1) + " ");
            }
        }
    }
}

