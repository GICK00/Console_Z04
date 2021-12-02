using System;

namespace Console_Z04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("| Вычесление значения функции.");
            bool repit = true;
            while (repit == true)
            {
                try
                {
                    Console.WriteLine("| Введите число N");
                    Console.Write("| N : ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("|------------------------------------");

                    if (n > 0)
                    {
                        Console.WriteLine("| Ответ: " + n / rec(n - 1, n));
                        rep(out repit);
                    }
                    else
                    {
                        Console.WriteLine("| N не может быть меньше 0!");
                        rep(out repit);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("|------------------------------------");
                    Console.WriteLine("| Некорректный ввод данных!");
                    rep(out repit);
                }   
            }
        }
        static double rec(int a, int n)
        {
            if (a == 0)
                return Math.Sqrt(n);
            else
                return Math.Sqrt((n - a) + rec(a - 1, n));
        }
        static void rep(out bool repit)
        {
            Console.WriteLine("| Попробовать снова? Да / Нет");
            Console.Write("| : ");
            string repitTxT = Convert.ToString(Console.ReadLine());

            if (repitTxT == "Да")
            {
                repit = true;
                Console.WriteLine("|------------------------------------");
            }
            else if (repitTxT == "Нет")
                repit = false;
            else
            {
                Console.WriteLine("|------------------------------------");
                Console.WriteLine("| Некорректный ввод данных!");
                repit = false;
            }
        }
    }
}