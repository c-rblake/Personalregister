using System;



/*
 * Har några saker att anmärka på. Du kommer lära dig alla dessa i framtida övningar men det är bra att det upprepas:
 


	
    Man gör en oläskig while-loop med hjälp av do-while. Då kan man ha en evigt upprepande meny som man har kontroll över.
	KLART Ett annat sätt att bygga strängar med variabler i är string s = $"Namn: {emp.Name}, Salary: {emp.salary}."
	Jag håller med om att utskriftsfunktionen bör ligga i Employeeklassen, men det är inget krav.

 */



namespace Personalregister
{
    class Program
    {
        static Payroll payroll = new Payroll(); // Access utifrån
        static void Main(string[] args)
        {

            // DO WHILE loop som lägger till anställda
            Console.WriteLine("Skriv Tre anställda (TEXT) och deras lön(Siffra) ");

            Employee employee = new("Ludvig", 10000);

            //Ett annat sätt att bygga strängar med variabler i är string s = $"Namn: {emp.Name}, Salary: {emp.salary}."
            string s = $"Namn: {employee.Name}, lön: {employee.Salary}.";
            Console.WriteLine(s);


            SeedData();

            Employee[] employees = payroll.GetEmployees();

            foreach (Employee emp in employees)
            {
                string e = $"Namn: {employee.Name}, lön: {employee.Salary}."; // Python F-string
                Console.WriteLine(e);
            }

        }

        private static void SeedData()
        {
            payroll.AddEmployee("Kalle", 20000);
            payroll.AddEmployee("Kalle", 20000);
            payroll.AddEmployee("Kalle", 20000);
        }

    }
}
