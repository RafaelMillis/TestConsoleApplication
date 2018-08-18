using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBizModels;
using TestDAL;

namespace TestBLL
{
    public class Bll
    {
        public List<Customer> GetCustomersAsynch()
        {
            Task<List<Customer>> task1 = Task<List<Customer>>
                    .Factory.StartNew(() =>
                    {
                        return dal.GetCustomers();
                    }
            );
            return task1.Result;
        }

        public List<Customer> GetCustomers()
        {
            return dal.GetCustomers();
        }

        public void CreateCustomer(Customer c)
        {
            dal.AddCustomer(c);
        }

        public void UpdateCustomer(Customer c)
        {
            dal.UpdateCustomer(c);
            //dal.UpdateCustomerSP(c);
        }

        public void DeleteCustomer(Customer c)
        {
            dal.DeleteCustomer(c);
        }

        public void DisplayCustomers(List<Customer> custs)
        {
            Task t = Task.Run(() =>
            {
                foreach (Customer c in custs)
                {
                    Console.WriteLine(c.Id + " " + c.Name);
                }
            }
            );
        }

        Dal dal = new Dal();
    }
}
