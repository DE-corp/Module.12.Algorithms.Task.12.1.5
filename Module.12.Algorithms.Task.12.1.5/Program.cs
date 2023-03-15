using System;
using System.Collections.Generic;
using System.Threading;

namespace Module._12.Algorithms.Task._12._1._5
{
    class Program
    {
        private static List<User> Users = new List<User>(){new User() { Login = "dmitry", Name = "Дмитрий", IsPremium = true },
                                   new User() { Login = "boris", Name = "Борис", IsPremium = false },
                                   new User() { Login = "evgeniy", Name = "Евгений", IsPremium = true } };
        static void Main(string[] args)
        {
            foreach (var user in Users)
            {
                Console.WriteLine($"Приветствуем Вас {user.Name}");
                if (!user.IsPremium)
                {
                    ShowAds();
                }
            }
        }

        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
}
