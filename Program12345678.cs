using System.Globalization;
using System.Text.RegularExpressions;

namespace Var6 {
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите пароль для проверки: ");
            string password = Console.ReadLine();


            if (password.Length < 8)
            {
                Console.WriteLine("Не подходит. Минимальная длина - 8 символов");
            }
            else if (!Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@#$%^&*_.-+])[A-Za-z\d@#$%^&*_-]+$"))
            {
                Console.WriteLine("В пароле должны быть строчные и прописные буквы, цифры, специальные символы");
            }
            else
            {
                Console.WriteLine("Подходит");
            }

            Console.ReadKey();

      
        }
    }
}

    
