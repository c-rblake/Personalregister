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
        static IUI ui = new ConsoleUI();
        static void Main(string[] args)
        {
            SeedData(); // LOAD STATE / DATA
            do
            {
                ShowMainMeny();
                UserInput();

            } while (true);
        }

        private static void UserInput()
        {
            switch (ui.GetInput())
            {
                case "1":
                    AddEmployee();
                    break;
                case "2":
                    PrintEmployees();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    ui.Print("Fel input");
                    break;
            }
        }

        private static void AddEmployee()
        {
            do
            {
                ui.Print("Lägg till antälld");
                string name = Util.AskForString("Name, ", ui);

                if (name.Equals("Q")) break;

                int salary = Util.AskForInt("Salary", ui);

                payroll.AddEmployee(name, salary);

            } while (true);
        }

        private static void PrintEmployees()
        {
            Employee[] employees = payroll.GetEmployees();

            foreach (Employee employee in employees) // MÅSTE GÖRA TYP innan printa i loop
            {
                ui.Print(employee);
            }
        }

        private static void SeedData() // OVERWRITE TO STRING
        {
            payroll.AddEmployee("Kalle", 20000);
            payroll.AddEmployee("Kalle2", 30000);
            payroll.AddEmployee("Kalle3", 40000);
        } // DEt är inte Line by Line här. Dessa lägs till innan foreach.

        private static void ShowMainMeny()
        {
            ui.Print("1. Add employee");
            ui.Print("2. Print employees");
            ui.Print("3. Quit");
        }
    }
}










        //// DO WHILE loop som lägger till anställda
        //Console.WriteLine("Skriv Tre anställda (TEXT) och deras lön(Siffra) ");

        //    Employee employee = new("Ludvig", 10000);

        //    //Ett annat sätt att bygga strängar med variabler i är string s = $"Namn: {emp.Name}, Salary: {emp.salary}."
        //    //string s = $"Namn: {employee.Name}, lön: {employee.Salary}.";
        //    //ui.Print(s);

        //    Employee[] employees = payroll.GetEmployees();

        //    foreach (Employee emp in employees)
        //    {
        //        string e = $"Namn: {emp.Name}, lön: {emp.Salary}."; // Python F-string
        //        Console.WriteLine(e);



        

 








        
   
