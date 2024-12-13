using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите вашу фамилию: ");
            var lastName = Console.ReadLine();
            Console.Write("Введите ваши имя: ");
            var firstName = Console.ReadLine();
            Console.Write("Введите ваше отчество: ");
            var midName = Console.ReadLine();
            Console.Write("Введите дату вашего рождения: ");
            var birthdayDate = Console.ReadLine();

            Console.Clear();
            Console.WriteLine($"Привет, меня зовут {lastName} {firstName} {midName}\nДата рождения {birthdayDate}");
            Console.ReadKey();
        }
    }
}
