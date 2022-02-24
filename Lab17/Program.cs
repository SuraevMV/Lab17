using System;

namespace Lab17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числовой номер счета");
            int accountInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите баланс счета");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ФИО");
            string name = Console.ReadLine();
            Bank<int> bank = new Bank<int>(accountInt, price, name);
            Console.WriteLine(bank.Info());

            Console.WriteLine("Введите строковый номер счета");
            string accountString = Console.ReadLine();
            Console.WriteLine("Введите баланс счета");
            price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ФИО");
            name = Console.ReadLine();
            Bank<string> bank1 = new Bank<string>(accountString, price, name);
            Console.WriteLine(bank1.Info());
            
            Console.ReadKey();
        }
    }
}
