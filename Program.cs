using System;

namespace SF4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            var (name, age) = ("Евгения", 276);

            Console.Write("Имя: {0}", name);
            Console.Write("Возраст: {0}", age);

            Console.Write("Введите новое имя: ");
            name = Console.ReadLine();
            Console.Write("Введите новый возраст цифрами: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Новое имя: {0}", name);
            Console.WriteLine("Возраст: {0}", age);

        }
    }
}
