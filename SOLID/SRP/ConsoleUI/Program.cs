namespace ConsoleUI
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();

            Person user = PersonDataCapture.Capture();

            bool isUserValid = PersonValidator.Validate(user);

            if (isUserValid is false)
            {
                StandardMessages.EndApplication();
                return;
            }

            AccouuntGenerator.CreateAccount(user);

            StandardMessages.EndApplication();
        }
    }
}
