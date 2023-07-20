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
            Console.WriteLine("Есть такие функции:");
            Console.WriteLine("Добавить клиента - введите add_customer name Last_name");
            Console.WriteLine("Добавить услугу - введите add_service name price");
            Console.WriteLine("Добавить работника - введите add_employee name Last_name position");
            Console.WriteLine("Вывести информацию о Барбершопе - введите print_all");
            Console.WriteLine("Чтобы выйти из программы введите q");
            Console.WriteLine("------------------------------------------------------------------");
        }
        public static void add_customer(string [] user_input_array)
        {
            if(user_input_array.Length < 3)
            {
                Console.WriteLine("Для добавления пользователя необходимо имя и фамилия!");
                return;
            }
            if(Barbershop.add_customer(user_input_array[1], user_input_array[2]))
            {
                Console.WriteLine("Клиент успешно добавлен");
            }
            else
            {
                Console.WriteLine("Клиент не был добавлен");
            }
        }
        public static void add_employee(string[] user_input_array)
        {
            if (user_input_array.Length < 4)
            {
                Console.WriteLine("Для добавления работника необходимо имя, фамилия и должность!");
                return;
            }
            if (Barbershop.add_employee(user_input_array[1], user_input_array[2], user_input_array[3]))
            {
                Console.WriteLine("Работник успешно добавлен");
            }
            else
            {
                Console.WriteLine("Работник не был добавлен");
            }
        }
        public static void add_service(string [] user_input_array)
        {
            if(user_input_array.Length < 3)
            {
                Console.WriteLine("Для добавления услуги необходимо назввание и цена!");
                return;
            }
            int price = 0;
            try
            {
                price = Convert.ToInt32(user_input_array[2]);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Цена должна быть целым числом");
                return;
            }
            if (price < 0)
            {
                Console.WriteLine("Цена должна быть целым положительным числом");
                return;
            }
            if (Barbershop.add_service(user_input_array[1], price))
            {
                Console.WriteLine("Услуга успешно добавлена");
            }
            else
            {
                Console.WriteLine("Услуга не была добавлена");
            }
        }
        static void Main(string[] args)
        {
            print_menu();
            string user_input = "";
            while(user_input != "q")
            {
                Console.WriteLine("Введите команду");
                user_input = Console.ReadLine();
                string[] user_input_array = user_input.Split(' ');
                if(user_input_array.Length == 0)
                {
                    Console.WriteLine("Пожалуйста, введи команду");
                    continue;
                }
                switch (user_input_array[0])
                {
                    case "add_customer": add_customer(user_input_array);
                        break;
                    case "add _service": add_service(user_input_array);
                        break;
                    case "add_employee": add_employee(user_input_array);
                        break;
                    case "print_all": Barbershop.print();
                        break;
                    case "q":
                        break;
                    default:
                        Console.WriteLine("Некоректный ввод");
                        break;
                }
            }
        }
    }
}