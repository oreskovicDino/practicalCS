namespace ConsoleUI
{
    using System;

    public class PersonDataCapture
    {
        public static Person Capture()
        {
            // Ask for usere information
            Person output = new Person();

            Console.WriteLine("What si your first name: ");
            output.FirstName = Console.ReadLine();

            Console.WriteLine("What si your last name: ");
            output.LastName = Console.ReadLine();

            return output;
        }
    }
}
