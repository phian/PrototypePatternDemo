using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatternDemo.DeepCloneExample
{
    class Registry
    {
        private Dictionary<CustomerType, Customer> customers = new Dictionary<CustomerType, Customer>();

        public Registry()
        {
            initialize();
        }

        public Customer getCustomerShallow(CustomerType customerType)
        {
            Customer customer = null;
            try
            {
                customer = customers.GetValueOrDefault(customerType).ShallowClone();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            return customer;
        }

        public Customer getCustomerDeep(CustomerType customerType)
        {
            Customer customer = null;
            try
            {
                customer = customers.GetValueOrDefault(customerType).DeepClone();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            return customer;
        }

        private void initialize()
        {
            LoyalCustomer loyalCustomer = new LoyalCustomer();
            loyalCustomer.Name = "Default Loyal Name";
            loyalCustomer.ContactNo = "070 000 0000";
            loyalCustomer.setDiscountRate(5.0);

            RegularCustomer regularCustomer = new RegularCustomer();
            regularCustomer.Name = "Default Regular Customer";
            regularCustomer.ContactNo = "070 000 0000";

            customers.Add(CustomerType.LOYAL, loyalCustomer);
            customers.Add(CustomerType.REGULAR, regularCustomer);

        }
    }
}
