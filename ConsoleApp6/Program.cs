using System;

namespace Program15
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = null;
            int f = 0;
            Console.WriteLine("Введите строку символов");
            str = Console.ReadLine(); //Переводим строчку в массив Char
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == str[i + 1])
                    f = 1;
            }

            if (f == 1)
                Console.WriteLine("Есть одинаковые символы 44");
            else
                Console.WriteLine("Нет одинаковых символов или не 44");

            Console.ReadLine();
        }
    }
}