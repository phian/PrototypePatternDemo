using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatternDemo.DeepCloneExample
{
    class LoyalCustomer : Customer
    {
        private double discountRate;

        public double DiscountRate
        {
            get
            {
                return discountRate;
            }
            set
            {
                discountRate = value;
            }
        }

        public override Customer DeepClone()
        {
            LoyalCustomer customer = new LoyalCustomer();
            customer.Name = (string)this.Name.Clone();
            customer.ContactNo = (string)this.Name.Clone();
            customer.DiscountRate = (double)this.DiscountRate;

            return customer;
        }

        public override Customer ShallowClone()
        {
            return this;
        }

        public double getDiscountRate()
        {
            return discountRate;
        }

        public void setDiscountRate(double discountRate)
        {
            this.discountRate = discountRate;
        }

        public override string ToString()
        {
            return " LoyalCustomer { \n" +
                    " Name = " + Name + ", \n" +
                    " Contact Number = " + ContactNo + ", \n" +
                    " Discount Rate = " + discountRate + "%\n" +
                    " }";
        }
    }
}
