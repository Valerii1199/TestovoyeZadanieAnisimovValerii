using System;

namespace ukrainee_trainee_Anisimov_Valerii
{

    class Program

    {
        static void Main(string[] args)
        {
            double num;
            Console.WriteLine("Введите число:");
            num = Convert.ToDouble(Console.ReadLine());

            if (num <= 7)
                Console.WriteLine("Ваше число " + num);
            else
                Console.WriteLine("Привет");
            Console.ReadKey();

        }
    }
}