using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Program
    {
        public static void print_menu()
        {
            Console.WriteLine("Привет! Это симуляция работы Барбершопа");
            Console.WriteLine("Есть такие функции");
            Console.WriteLine("Добавить клиента - введите add_customer name Last_name");
            Console.WriteLine("Добавить услугу - введите add_service name price");
            Console.WriteLine("Ведите информацию о Барбершопе - введите print_all");
            Console.WriteLine("Чтобы выйти из программы нажмите q");
        }
        static void Main(string[] args)
        {

            Console.ReadLine();
        }
    }
}
