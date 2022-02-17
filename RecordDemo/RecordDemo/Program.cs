namespace RecordDemo
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Record1 r1a = new Record1("Anita", "Rutnik");
            Record1 r1b = new Record1("Anita", "Rutnik");
            Record1 r1c = new Record1("Tim", "Corey");

            Class1 c1a = new Class1("Anita", "Rutnik");
            Class1 c1b = new Class1("Anita", "Rutnik");
            Class1 c1c = new Class1("Tim", "Corey");

            Console.WriteLine("Record Type:");
            Console.WriteLine($"To String: { r1a }");
            Console.WriteLine($"Are the two objects equal: { Equals(r1a, r1b) }");
            Console.WriteLine($"Are the two objects reference equal: { ReferenceEquals(r1a, r1b) }");
            Console.WriteLine($"Are the two objects == : { r1a == r1b }");

            Console.WriteLine();
            Console.WriteLine("*************************************************************************");
            Console.WriteLine();

            Console.WriteLine("Class Type:");
            Console.WriteLine($"To String: { c1a }");
            Console.WriteLine($"Are the two objects equal: { Equals(c1a, c1b) }");
            Console.WriteLine($"Are the two objects reference equal: { ReferenceEquals(c1a, c1b) }");
            Console.WriteLine($"Are the two objects == : { c1a == c1b }");

            var (fn, ln) = r1c;
            Console.WriteLine($"The value of the fn: { fn } and ln: { ln }");
        }
    }
}
