namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Person> GetPersons()
        {
            return new List<Person>()
            {
                new Person() { FirstName = "Ross", Middlename = "Gellar", LastName = "DeleteFromShow" },
                new Person() { FirstName = "Joey", Middlename = "Tribiany" },
                new Person() { FirstName = "Chandler", Middlename = "Bing"},
                new Person() { FirstName = "unknown", Contacts = new Contacts() { PhoneNumber = "9379992" } }

            };


        }
        private void button_Click1(object sender, EventArgs e)
        {

            //listBox1.Items.Clear();
            //var persons = GetPersons();

            //foreach (var person in persons)
            //{
            //    listBox1.Items.Add($"{person.GetFullName()} | {person.GetPhoneNumber()}");
            //}
        }
    }
}