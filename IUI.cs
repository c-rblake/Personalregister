namespace Personalregister
{
    public interface IUI
    {
        string GetInput();
        void Print(string message);
        void Print(Employee employee); // Annan Signatur
    }
}