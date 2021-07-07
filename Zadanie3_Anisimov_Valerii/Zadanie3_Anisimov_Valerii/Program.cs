using System;

namespace Zadanie3_Anisimov_Valerii
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задать с клавиатуры число элементов массива
            int n;
            Console.WriteLine("Введите число элементов массива");
            n = Convert.ToInt16(Console.ReadLine());
            // Объявим одномерный массив Data с n-элементами 
            double[] Tara = new double[n];
            int i = 0;
            while (i < n)
            {
                Console.WriteLine("Введите элемент массива");
                /* Вводим элементы массива с клавиатуры 
                * и заполняем ими массив */
                Tara[i] = double.Parse(Console.ReadLine());
                Console.WriteLine();
                i++;
            }
            // Вывод содержимого массива
            for (i = 0; i < n; i = i + 1)
                Console.Write(Tara[i] + " ");


            int v = 0;
            Console.WriteLine("\nКратные трём:");
            for (i = 0; i < n; i++)
                if (Convert.ToInt32(Tara[i]) % 3 == 0) { Console.WriteLine("Data[" + i + "]=" + Tara[i]); v++; }
            Console.WriteLine("Всего:" + v);
            Console.ReadKey();
        }
    }
}

  