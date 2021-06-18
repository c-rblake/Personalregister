using System;

namespace Personalregister
{
    internal class Util
    {
        internal static string AskForString(string promt, IUI ui)
        {
            bool success = false;
            string answer;

            do
            {
                ui.Print(promt);
                answer = ui.GetInput();

                if (string.IsNullOrWhiteSpace(answer))
                {
                    ui.Print("Skriv in något");
                }
                else
                {
                    success = true;
                }
                


            } while (!success);

            return answer;
            
        }

        internal static int AskForInt(string prompt, IUI ui)
        {
            bool success = false;
            int answer;

            do
            {
                string input = AskForString(prompt, ui); // samma kod som ovan Men kolla att det är en int.
                success = int.TryParse(input, out answer) && answer > 0;// Assigns the output to answer & Checks True False for Int Parse.

                if (!success)
                    ui.Print("Error");

            } while (!success);

            return answer;

        }
    }
}