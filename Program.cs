using System;

namespace Personalregister
{
    class Program
    {
        static void Main(string[] args)
        {

            // While Loop ? MEN DE ÄR FÖR LÄSKIGA.
            Employee emp = new();
            Console.WriteLine("Name på anställd");
            string namn = Console.ReadLine();
            emp.AddName(namn);

            Console.WriteLine("Lön för anställd");
            float lon = float.Parse(Console.ReadLine());
            emp.AddSalary(lon);


            Console.WriteLine("Antal anställda: ", emp.salaries.Count.ToString()) ;

            // print For loops i in range ...
            //Console.WriteLine(emp.salaries[0]);
            //Console.WriteLine(emp.names[0]);

            // Bättre som method i Employees class.
            {
                for (int i = 0; i < emp.salaries.Count; i++)
                {
                    Console.WriteLine("*******************************");
                    Console.WriteLine("Anställd: {0} Lön: {1}", emp.names[i], emp.salaries[i]);
                }
            }


            // Console.WriteLine(emp.salaries);
        }

    }
}
