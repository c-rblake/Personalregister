using System;

namespace Personalregister
{
    class Program
    {
        static void Main(string[] args)
        {

            // WHile Loop ?
            Employee emp = new();
            Console.WriteLine("Name på anställd");
            string namn = Console.ReadLine();
            emp.AddName(namn);

            Console.WriteLine("Lön för anställd");
            float lon = float.Parse(Console.ReadLine());
            emp.AddSalary(lon);

            
            Console.WriteLine(emp.salaries.Count);

            // print For loops i in range ...
            Console.WriteLine(emp.salaries[0]);
            Console.WriteLine(emp.names[0]);


            // Console.WriteLine(emp.salaries);
        }

    }
}
