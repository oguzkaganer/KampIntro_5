﻿namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[]
            {
                new Worker(),
                new Manager(),
                new Robot()
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[]
            {
                new Worker(),
                new Manager(),
            };

            foreach (var eat in eats)
            {
                eat.Eat();
            }
        }
    }

    interface IWorker
    {
        void Work();
    }

    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void Salary();
    }

    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Salary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Salary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}