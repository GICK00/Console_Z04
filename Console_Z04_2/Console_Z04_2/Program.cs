using System;

namespace Console_Z04_2
{
    class Program
    {
        static string str;
        static void Main(string[] args)
        {
            Console.WriteLine("| Перевод чисола из 10 в 2 систему.");
            bool repit = true;
            while (repit == true)
            {
                try
                {
                    Console.Write("| Введите число: ");
                    int number = Convert.ToInt32(Console.ReadLine());

                    if (number > 0)
                    {
                        dvoich(number);
                        Console.WriteLine("|-------------------------------------");
                        Console.WriteLine("| Число в 2 системе: {0}", revString(str));
                        rep(out repit);
                    }
                    else
                    {
                        Console.WriteLine("|----------------------------------");
                        Console.WriteLine("| Число должно быть > 0!");
                        rep(out repit);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("|----------------------------------");
                    Console.WriteLine("| Некорректный ввод данных!");
                    rep(out repit);
                }
                str = "";
            }
        }
        static void dvoich(int i)
        {
            if (i > 0)
            {
                if (i % 2 == 1)
                    str += "1";
                else
                    str += "0";
                dvoich(i / 2);
            }
        }
        static string revString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        static void rep(out bool repit)
        {
            Console.WriteLine("| Попробовать снова? Да / Нет");
            Console.Write("| : ");
            string repitTxT = Convert.ToString(Console.ReadLine());

            if (repitTxT == "Да")
            {
                repit = true;
                Console.WriteLine("|----------------------------------");
            }
            else if (repitTxT == "Нет")
                repit = false;
            else
            {
                Console.WriteLine("|----------------------------------");
                Console.WriteLine("| Некорректный ввод данных!");
                repit = false;
            }
        }
    }
}