namespace RecordDemo
{
    // a Record is just a fancy class.
    // Immutable - The value can't be changed.
    public record Record1(string FirstName, string LastName);

    public class Class1
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }

        public Class1(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
