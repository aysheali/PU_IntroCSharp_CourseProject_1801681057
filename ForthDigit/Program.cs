using System;
using System.Text;

namespace ForthDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която въвежда положително седемцифрено число и извежда неговата 4-та цифра.(стр.31/зад.12)

            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Въведете 7 цифрено положително число:");
            int a = int.Parse(Console.ReadLine());
            int x = a / 100 % 100 / 10;
            Console.WriteLine("Четвъртата цифра е:" + x);
        }
    }
}