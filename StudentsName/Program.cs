using System;
using System.Text;

namespace StudentsName

{
    class Program
    {
        static void Main(string[] args)
        {
            /* Елементите на масив са имена на студенти (име, презиме, фамилия. Да се съставят методи за:
             а) въвеждане на елементите на масива (не повече от 50)
             б) извеждане на екрана на имената на всички студентки (имената им завършват на "а"), които имат в именета си Иван (иван). 

             стр.211/зад.371
            */
            Input();
        }

        static void Input()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            do
            {
                Console.WriteLine("Въведете брой студент между 1 и 50: ");
                n = int.Parse(Console.ReadLine());
            }
            while (n < 1 || n > 50);

            string[] studentsNames = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Въведете трите имена на студента:" + (i + 1) + ":");
                string name = Console.ReadLine();
                studentsNames[i] = name;
            }

            for (int i = 0; i < n; i++)
            {
                int index = studentsNames[i].IndexOf(' ');
                if (studentsNames[i][index - 1] == 'a')
                {
                    if (studentsNames[i].Contains("иван") || studentsNames[i].Contains("Иван"))
                    {
                        Console.Write("Имената на студентите, които отговарят на критериите са:");
                        Console.WriteLine(studentsNames[i]);
                    }
                }
            }
        }
    }
}


