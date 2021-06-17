using System.Collections.Generic;

namespace Personalregister

    // Lägga till employee och hämta ut.
{
    internal class Payroll
    {
        private List<Employee> payroll; // sparar employees Tuple i python. Typ privat lista
        public Payroll()
        {
            payroll = new List<Employee>(); // Instanciate
        }

        public void AddEmployee(string name, int salary) // Void ingen return. Static(Global?) kommer åt från alla.
        {
            payroll.Add(new Employee(name, salary));

        }

        public Employee[] GetEmployees()
        {
            return payroll.ToArray(); // Skapar kopia Påverkar inte objected payroll.
        }

    }
}