using System;

namespace Personalregister
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Skriv Tre anställda (TEXT) och deras lön(Siffra) ");

            Employee emp = new();
            // While Loop ? MEN DE ÄR FÖR LÄSKIGA.
            {
                for (int i = 0; i < 3; i++)
                {
                    
                    Console.WriteLine("Name på anställd");
                    string namn = Console.ReadLine();
                    emp.AddName(namn);
                    // Kolla Typ If string ELSE

                    Console.WriteLine("Lön för anställd");
                    float lon = float.Parse(Console.ReadLine());
                    emp.AddSalary(lon);
                    // Kolla Typ If int ELSE
                }
            }

            Console.WriteLine("ANTAL ANSTÄLLDA:");
            Console.WriteLine(emp.salaries.Count.ToString()) ;

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
