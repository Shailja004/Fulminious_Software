using System;
namespace CustomerInfo
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*-----------Customer's Details----------*");
            Console.WriteLine("Enter customer details : ");
            while (true)
            {
                List<Customer> customers = new List<Customer>();
                {
                    Console.Write("Enter Customer Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter Customer Phone: ");
                    string phone = Console.ReadLine();

                    Console.Write("Enter Customer Email: ");
                    string email = Console.ReadLine();

                    Console.Write("Enter Customer Age: ");
                    int age = Convert.ToInt32(Console.ReadLine());

                    Customer customer = new Customer { CustomerName = name, CustomerPhone = phone, CustomerEmail = email, CustomerAge = age };
                    IVerifier verify = new Condition();
                    if (verify.IsValid(customer))
                    {
                        customers.Add(customer);
                    }
                }
                if (customers.Count > 0)
                {
                    ISave_information save = new Store_Information("customr.txt");
                    save.SaveCustomers(customers);
                    Console.WriteLine("*---------Customers data saved---------*");
                }
                else
                {
                    Console.WriteLine("Sorry");
                }
                Console.WriteLine("Enter next customer details : ");
            }
        }
    }
}


