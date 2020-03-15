using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class employee
    {
        private static int cur_max_id = 0;
        private int id;
        public string name;
        public string Last_name;
        private string position;
        public employee(string name, string Last_name,string position)
        {
            id = cur_max_id;
            cur_max_id++;
            this.name = name;
            this.Last_name = Last_name;
            this.position = position;
        }
        public void print()
        {
            Console.WriteLine("___________________");
            Console.WriteLine("Продавец № " + id + ";");
            Console.WriteLine(position + " " + name + " " + Last_name);
            Console.WriteLine("____________________");
        }
        public bool is_compare(employee employee)
        {
            if (id == employee.id && name == employee.name && Last_name == employee.Last_name && position == employee.position)
            {
                return true;
            }
            return false;
        }
    }
}
