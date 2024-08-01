using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerInfo
{
    public interface ISave_information
    {
        void SaveCustomers(List<Customer> customers);
    }
}
