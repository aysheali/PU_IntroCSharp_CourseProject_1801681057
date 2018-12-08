using System;
using System.Text;

namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Да  се генерира редица от 32 случайни цели числа принедлежащи на интервала [0, 50]. Да се отпечатат тези от тях, които са положителни
               2. да се въведат от клавиатурата 7 числа. Да се намери и отпечата на екрана сумата на тези от тях, които отговарят на следното условие: 
               да са отрицателни или по-големи от 200.
               3. Да се създаде метод Sred(k), който генерире k на брой случайни цели числа и като резултат връща средноаритметичното на тези от тях,
               които са в интервала [10, 100]. В главния метод да се въведат 3 цели положителни числа a,b и c. Да се намери и отпечата: Sred(|a-b|)-Sred(|c+a|).

                стр.213/зад.375
            */
            Console.OutputEncoding = Encoding.UTF8;

            RandomNumbers();
            SevenNumbers();

            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете 3 цели, положителни числа:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            double result1 = Math.Abs(a - b);
            double result2 = Math.Abs(c + a);
            Console.Write("Резултатът от Sred(|a-b|)-Sred(c+a) е:");
            Console.WriteLine(result1 - result2);
            Console.ReadKey(true);
        }

        static void RandomNumbers()
        {
            int[] numbers = new int[64];

            for (int i = 0; i < numbers.Length; i++)
            {
                Random rnd = new Random();
                numbers[i] = rnd.Next(0, 50);
                if (i % 2 == 0 && numbers[i] > 0 && numbers[i] <= 50)
                    Console.WriteLine(numbers[i]);
            }
        }

        private static void SevenNumbers()
        {
            int sum = 0;

            for (int i = 1; i <= 7; i++)
            {
                Console.WriteLine("Въведете число");
                int inputNumber = int.Parse(Console.ReadLine());

                if (inputNumber < 0 || inputNumber > 200)
                {
                    sum += inputNumber;
                }
            }
            Console.Write("Сумата на седемте числа е:");
            Console.WriteLine(sum);
        }

        private static double Sred(int k)
        {
            Random random = new Random();
            int[] arr = new int[k];

            int average = 0;
            for (int i = 0; i < k; i++)
            {
                arr[i] = random.Next();
                if (arr[i] >= 10 && arr[i] <= 100)
                {
                    average += arr[i];
                }
            }

            double result = average / k;
            return result;

        }

    }
}

