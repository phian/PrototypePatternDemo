using PrototypePatternDemo.DeepCloneExample;
using System;

namespace PrototypePatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Shallow cloning
            Registry registry = new Registry();
            LoyalCustomer c1 = (LoyalCustomer)registry.getCustomerShallow(CustomerType.LOYAL);
            Console.WriteLine(" c1\n" + c1);
            Console.WriteLine();

            LoyalCustomer c2 = (LoyalCustomer)registry.getCustomerShallow(CustomerType.LOYAL);
            c2.Name = "Tom";
            c2.ContactNo = "071 123 4567";
            c2.setDiscountRate(7.0);
            Console.WriteLine(" c2\n" + c2);
            Console.WriteLine(" \nc1\n" + c1);
            Console.WriteLine();

            RegularCustomer c3 = (RegularCustomer)registry.getCustomerDeep(CustomerType.REGULAR);
            Console.WriteLine(" c3\n" + c3);
            Console.WriteLine();

            RegularCustomer c4 = (RegularCustomer)registry.getCustomerDeep(CustomerType.REGULAR);
            c4.Name = "Nguyen Van A";
            c4.ContactNo = "012 345 6789";
            Console.WriteLine(" c4\n" + c4);
            Console.WriteLine(" \nc3\n" + c3);
            Console.WriteLine();
        }
    }
}
