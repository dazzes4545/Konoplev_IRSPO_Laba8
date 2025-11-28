using MyApp.Models;
namespace DZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zad1
            //Car car1 = new Car();
            //car1.Brand = "Toyota";
            //car1.Model = "Camry";
            //car1.Year = 2020;
            //car1.Mileage = 45000;
            //car1.PrintInfo();

            //Car car2 = new Car();
            //car2.Brand = "BMW";
            //car2.Model = "X5";
            //car2.Year = 2022;
            //car2.Mileage = 15000;
            //car2.PrintInfo();


            //zad2
            User user1 = new User();
            user1.Name = "Ivan Petrov";
            user1.Email = "ivan.petrov@mail.ru";
            user1.IsActive = true;

            Console.WriteLine($"Имя: {user1.Name}");
            Console.WriteLine($"Email: {user1.Email}");
            Console.WriteLine($"Активен: {user1.IsActive}");
        }
    }
}
