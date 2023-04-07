using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome To Exception in C#");
            Console.WriteLine("Enter your Age");
            int age = Convert.ToInt32(Console.ReadLine());
            Categorized categorized = new Categorized();
            categorized.GetCategory(age);
            Console.ReadLine();
        }
    }
}
