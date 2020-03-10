using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Customer
    {
        private static  int cur_max_id = 0;
        private int id;
        public string name;
        public string Last_name;
        public  Customer (string name, string Last_name)
        {
            id = cur_max_id;
            cur_max_id ++;
            this.name = name;
            this.Last_name = Last_name;
        }
        public void print()
        {
            Console.WriteLine("___________________");
            Console.WriteLine("Клиент № "+ id + ";");
            Console.WriteLine(name + " " + Last_name);
            Console.WriteLine("____________________");
        }
        public bool is_compare(Customer customer)
        {
            if (id == customer.id && name == customer.name && Last_name == customer.Last_name)
            {
                return true;
            }
                return false;
        }
    }
}
