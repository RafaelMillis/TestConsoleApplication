using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBizModels;
using TestBLL;
namespace TestConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ///todo: TASK pass paramter

            Bll bll = new Bll();
            //bll.CreateCustomer(new Customer { Id = 4, Name = "four" });
            //bll.UpdateCustomer(new Customer { Id = 4, Name = "four 4" });
            //bll.DeleteCustomer(new Customer { Id = 4, Name = "four 4" });

            //return value
            //List<Customer> custs = new List<Customer>();
            //Console.WriteLine("Start GetCustomersAsynch");
            //custs = bll.GetCustomers();
            //Console.WriteLine("End GetCustomersAsynch");
            //bll.DisplayCustomers(custs);         


            Program p = new Program();
            Task t1 = new Task(p.Print1);
            Task t2 = new Task(p.Print2);
            Task t3 = new Task(p.Print3);
            Task t4 = new Task(p.Print4);
            t2.Start();
            t3.Start();
            t4.Start();
            t1.Start();

            Task.WaitAll(t2, t3, t4);
            //t1.Wait();

            Console.WriteLine("press any key to continue");
            Console.ReadKey();


        }

        public void Print1()
        {
            Console.Write(1);
        }
        public void Print2()
        {
            Console.Write(2);
        }
        public void Print3()
        {
            Console.Write(3);
        }
        public void Print4()
        {
            Console.Write(4);
        }
    }
}
