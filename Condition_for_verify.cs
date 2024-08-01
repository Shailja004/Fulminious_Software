using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerInfo
{
    public class Condition : IVerifier
    {
        public bool IsValid(Customer customer)
        {
            if (customer.CustomerAge < 18)
            {
                Console.WriteLine("Customer is not eligible.");
                return false;
            }
            return true;

        }
    }
}
