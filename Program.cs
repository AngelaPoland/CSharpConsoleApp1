using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Console.WriteLine(person1.getAge());
            person1.setAge(29);
            Console.WriteLine(person1.getAge());
        }
    }
}
