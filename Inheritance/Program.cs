namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();

            Student student = new Student();

            Person[] people = new Person[]
            {
                new Customer{FirstName="Oğuz"},
                new Student{FirstName="Harun"},
                new Person{FirstName="Kübra"},
            };

            foreach (var person in people)
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine();
        }
    }

    internal class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    internal class Customer : Person
    {
        public string City { get; set; }
    }

    internal class Student : Person
    {
        public string Depertment { get; set; }
    }
}