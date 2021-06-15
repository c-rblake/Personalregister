using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalregister
{

    class Employee
    {
        List<string> names = new();
        List<float> salaries = new();

        public void AddName(string name)
        {
            names.Add(name);
        }

        public void AddSalary(float salary)
        {
            salaries.Add(salary);
        }




    }
}
