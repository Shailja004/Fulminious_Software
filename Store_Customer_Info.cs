using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerInfo
{
    public class Store_Information : ISave_information
    {
        string _filePath;
        public Store_Information(string File)
        {
            _filePath = File;
        }
        public void SaveCustomers(List<Customer> customers)
        {
            {
                foreach (var customer in customers)
                {
                   File.AppendAllText("customer.txt", customer.CustomerName + "  " + customer.CustomerPhone + "  " + customer.CustomerEmail + "  " + customer.CustomerAge + "\n");
                }
            }
        }
    }
}
