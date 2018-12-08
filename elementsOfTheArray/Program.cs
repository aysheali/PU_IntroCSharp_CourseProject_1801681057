using System;
using System.Text;

namespace elementsOfTheArray
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             1. Да се направят два метода:
             а) за въвеждане на едномерен целочислен масивм
             б)за изчисляване на средноаритметичното на тези елементи на целочисления масив, които се делят на 7 без остатък.
             2. В главния метод въведете цяло число n и три едномерни целочислени масива A[n], B[n] и C[n]. За всеки масив изчислете и отпечатайте стойността
                на средноаритметичното по точка 1б. Намерете и отпечатайте минималната от трите средноаритметични стойности.
             3. Преизчислете елементите на масива С по следния начин:
                (an-(n-a)b1,an-1-(n-2)b2,…..,a2-bn-1,a1)

            стр. 223/зад. 409
             */


            int n;
            float average1 = 0;
            float average2 = 0;
            float average3 = 0;
            Console.Write("Enter size of the array:  n = ");
            n = int.Parse(Console.ReadLine());

            int[] A = new int[n];
            Input(A);
            average1 = Average7(A);
            Console.WriteLine("Average: " + average1);

            int[] B = new int[n];
            Input(B);
            average1 = Average7(B);
            Console.WriteLine("Average: " + average2);


            int[] C = new int[n];
            Input(C);
            average1 = Average7(C);
            Console.WriteLine("Average: " + average3);

            float[] avr = { average1 + average2 + average3 };

            for (int i = 1; i < avr.Length; i++)
                for (int j = avr.Length - 1; j >= i; j--)
                    if (avr[j - 1] > avr[j])
                    {
                        float x = avr[j - 1];
                        avr[j - 1] = avr[j];
                        avr[j] = x;
                    }

            Console.WriteLine("The smallest average is: " + avr[0]);
            Console.WriteLine();

            int k = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                C[k] = A[i] - (n - k - 1) * B[k];
                Console.Write("C[" + k + "] = " + C[k]);
                Console.WriteLine();
                k++;
            }
        }
        public static void Input(int[] a)
        {

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("a[" + i + "]= ");
                a[i] = int.Parse(Console.ReadLine());

            }
        }

        public static float Average7(int[] a)
        {
            float sum = 0, b = 0, average7;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 7 == 0)
                {
                    sum = sum + a[i];
                    b++;
                }
            }
            if (b == 0)
                return average7 = 0;
            return average7 = sum / b;
        }
    }
}


