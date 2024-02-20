namespace ConsoleApp11
{
    public class Person
    {
        public string FirstName { get; set; }
        public string Middlename { get; set; }
        public string LastName { get; set; }

        public Contacts Contacts { get; set; }

        public string GetFullName()
        {
            return $"SecondName: {LastName ?? "#NA"} | Name: {FirstName ?? "#NA"} | LastName: {Middlename ?? "#NA"}";
        }
        public string GetPhoneNumber()
        {
            return $"PhoneNumber: {Contacts?.PhoneNumber ?? "#NA"}";
        }
    }
}