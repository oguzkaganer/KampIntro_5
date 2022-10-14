using Interfaces;



internal class Program
{
    private static void Main(string[] args)
    {

        //InterfacesIntro();
        //Demo();

        List<ICustomerDal> customerDals2 = new List<ICustomerDal>();

        customerDals2.Add(new SqlServerCustomerDal());


        foreach (var item in customerDals2)
        {
            item.Add();
        }

        Console.WriteLine("----");
        ICustomerDal[] customerDals = new ICustomerDal[]
        {
            new SqlServerCustomerDal(),
            new OracleCustomerDal(),
            new MySqlCustomerDal(),
        };

        foreach (var customerDal in customerDals)
        {
            customerDal.Add();
        }











        Console.ReadLine();

        static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();

            Customer customer1 = new Customer
            {
                Id = 1,
                FirstName = "Oğuz",
                LastName = "ER",
                Address = "İstanbul"
            };

            Student student1 = new Student
            {
                Id = 2,
                FirstName = "Kerem",
                LastName = "PAŞA",
                Departmant = "Bilg. Müh."
            };

            manager.Add(customer1);
            manager.Add(student1);
        }

        static void Demo()
        {
            SqlServerCustomerDal sqlServer = new SqlServerCustomerDal();
            sqlServer.Add();

            ICustomerDal customerDal = new OracleCustomerDal();
            customerDal.Add();

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(new OracleCustomerDal());
        }
    }
}

interface IPerson
{
    int Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }

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
    public void Add(IPerson person)
    {
        Console.WriteLine(person.FirstName);
    }
}