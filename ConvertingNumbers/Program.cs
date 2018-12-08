using System;

namespace ConvertingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Преобразуване на число в двоична,осмична и шистнадесетична броична система.
            int number = 2057;
            Console.WriteLine($"Стойността която ще се конвентира в: {number}");
            string binary1 = (Convert.ToString(number, 16));
            string binary2 = (Convert.ToString(number, 8));
            string binary3 = (Convert.ToString(number, 2));
            Console.WriteLine($"Стойността на {number} в 16-тична броична системе е: {binary1}");
            Console.WriteLine($"Стойността на {number} в 8-ична броична системе е: {binary2}");
            Console.WriteLine($"Стойността на {number} в 2-ична броична системе е: {binary3}");
        }
    }
}

