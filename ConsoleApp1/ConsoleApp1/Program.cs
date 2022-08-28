using ConsoleApp1.Controller;
using System;


namespace ConsoleApp1.Controller.UserController
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Консольное приложение фитнес-приложение.");
            Console.WriteLine("Введите имя пользователя");

            var name = Console.ReadLine();

            Console.WriteLine("Введите пол");

            var gender = Console.ReadLine();

            Console.WriteLine("Введите дату рождения");
            var birthday = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Введите вес");
            var weight = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введите рост");
            var height = Double.Parse(Console.ReadLine());

            var userController = new UserController(name, gender, birthday, weight, height);

            userController.Save();


        }
    }
}
