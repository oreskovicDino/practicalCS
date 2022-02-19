namespace ConsoleUI
{
    using System;

    public class AccouuntGenerator
    {
        public static void CreateAccount(Person user)
        {
            Console.WriteLine($"Your username is { user.FirstName.Substring(0, 1)}{ user.LastName}");
        }
    }
}
