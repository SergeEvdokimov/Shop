using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Service
    {
        private static int cur_max_id = 0;
        private int id;
        public string name;
        public int price;
        public Service (string name, int price)
        {
            id = cur_max_id;
            cur_max_id ++;
            this.name = name;
            this.price = price;
        }
        public void print()
        {
            Console.WriteLine("___________________");
            Console.WriteLine("Услуга № " + id + ";");
            Console.WriteLine("Название - " + name);
            Console.WriteLine("Цена - " + price);
            Console.WriteLine("____________________");
        }
        public bool is_compare(Service service)
        {
            if (id == service.id && name == service.name && price  == service.price)
                return true;
            return false;
        }

    }
}
