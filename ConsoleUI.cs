using System;

namespace Personalregister
{
    public class ConsoleUI : IUI
    {
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
        public void Print(Employee employee)
        {
            Console.WriteLine(employee);
        }

        public string GetInput()
        {
            return Console.ReadLine();
        }
    }
}