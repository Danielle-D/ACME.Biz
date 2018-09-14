using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.Biz
{
    public class CustomerRepository
    {
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            if (customerId == 1)
            {
                customer.EmailAddress = "dsmith@gmail.com";
                customer.FirstName = "David";
                customer.LastName = "Smith";

            }
            return new Customer();
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }
        /// <summary>
        /// Saves the current customer.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }
    }
}
