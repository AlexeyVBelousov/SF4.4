using System;

namespace SF4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            (string name, string type, double age, int namecount) pet;

            Console.Write("Введите имя зверя: ");
            pet.name = Console.ReadLine();
            Console.Write("Введите вид зверя: ");
            pet.type = Console.ReadLine();
            Console.Write("Введите возраст зверя цифрами: ");
            pet.age = Convert.ToInt32(Console.ReadLine());
            pet.namecount = pet.name.Length;

            Console.WriteLine("");

            Console.WriteLine("Имя Зверя: {0}", pet.name);
            Console.WriteLine("Вид Зверя: {0}", pet.type);
            Console.WriteLine("Возраст Зверя: {0}", pet.age);
            Console.WriteLine("Длина имени Зверя: {0}", pet.namecount);

        }
    }
}
