namespace Interfaces2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonManager manager = new PersonManager();

            manager.Add(new Customer { Id = 1, FirstName = "Oğuz", LastName = "ER", Address = "İstanbul" });

            Student student = new Student
            {
                Id = 2,
                FirstName = "Kerem",
                LastName = "PAŞA",
                Departmant = "Bilg. Müh."
            };

            manager.Add(student);

            Console.ReadLine();
        }
    }

    class IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }


    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson customer)
        {
            Console.WriteLine(customer.);
        }
    }
}