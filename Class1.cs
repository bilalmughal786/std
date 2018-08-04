using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_library
{
    public class student
    {
        public void show()
        {
            Console.WriteLine("show method in student class");
        }
    }

    public class customer
    {
        public void run()
        {
            Console.WriteLine("run method in customer class");
        }
    }

    public class khan : customer
    {
        static void Main(string[] args)
        {
            new customer();
        }
    }
}
