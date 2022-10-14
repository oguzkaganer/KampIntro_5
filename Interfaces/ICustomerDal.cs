namespace Interfaces
{
    internal interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();

    }

    internal class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("sql added");
        }

        public void Delete()
        {
            Console.WriteLine("sql deleted");
        }

        public void Update()
        {
            Console.WriteLine("sql updated");
        }
    }

    internal class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("oracle added");
        }

        public void Delete()
        {
            Console.WriteLine("oracle deleted");
        }

        public void Update()
        {
            Console.WriteLine("oracle updated");
        }
    }

    internal class MySqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("mysql added");
        }

        public void Delete()
        {
            Console.WriteLine("mysql deleted");
        }

        public void Update()
        {
            Console.WriteLine("mysql updated");
        }
    }
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
