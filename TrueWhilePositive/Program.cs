using System;

namespace TrueWhilePositive
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Запишете израз, който е истина при изпълнение на указаното условие и лъжа в противен случай: Всяко от числата x, y, z е положително. 
                
                стр.37/зад. 36 д)
            */
            Console.WriteLine("x=");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("y=");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("z=");
            double z = double.Parse(Console.ReadLine());

            if (x > 0)
                if (y > 0)
                    if (z > 0)
                        Console.WriteLine("TRUE");
                    else
                        Console.WriteLine("FALSE");

        }
    }
}
