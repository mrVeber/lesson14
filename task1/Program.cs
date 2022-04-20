using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Гав");
            Dog dog = new Dog("Кузя");

            cat.ShowInfo();
            dog.ShowInfo();

            Console.ReadKey();
        }
    }
}
