namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add("Ulaş");

            //CustomerManager[] customerManagers = new CustomerManager[50];
            //List<CustomerManager> customerManagers1 = new List<CustomerManager>();

            ProductManager productManager = new ProductManager();
            productManager.Add("Computer");

            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Oğuz";
            customer1.LastName = "ER";
            customer1.City = "Istanbul";

            Console.WriteLine(customer1.FirstName);

            Console.ReadLine();
        }
    }
}