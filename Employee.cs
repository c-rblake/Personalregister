namespace Personalregister
{

    public class Employee
    {
        //public List<string> names = new(); //STATE, inte bra Public Field.
        //public List<float> salaries = new();
        // List<float> salaries = new(); NOT ACCESSIBLE, default is private
        public string Name { get; } // Set with constructor
        public float Salary { get; }

        public SalaryLevel SalaryLevel => Salary < 25000 ? SalaryLevel.junior : SalaryLevel.senior;
        // SAMMA som 
        //public SalaryLevel SalaryLevel2
        //{
        //    get
        //    {
        //        if (Salary < 25000)
        //            return SalaryLevel.Junior;
        //        else
        //            return SalaryLevel.Senior;
        //    }
        //}

        public Employee(string name, int salary)
        {
            this.Name = name;
            this.Salary = salary;
        }

        public override string ToString()
        {
            return $"Namn: {this.Name} Lön: {this.Salary}";
        }
        //public void AddName(string name) // BEHAVIOR
        //{
        //    names.Add(name);
        //}

        //public void AddSalary(float salary)
        //{
        //    salaries.Add(salary);
        //}


    }
}
