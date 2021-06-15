using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalregister
{

    class Employee
    {
        public List<string> names = new();
        public List<float> salaries = new();
        // List<float> salaries = new(); NOT ACCESSIBLE

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
