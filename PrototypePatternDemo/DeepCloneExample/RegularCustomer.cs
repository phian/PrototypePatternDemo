using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatternDemo.DeepCloneExample
{
    class RegularCustomer : Customer
    {
        public override Customer DeepClone()
        {
            RegularCustomer customer = new RegularCustomer();
            customer.Name = (string)this.Name.Clone();
            customer.ContactNo = (string)this.Name.Clone();

            return customer;
        }

        public override Customer ShallowClone()
        {
            return this;
        }

        public override string ToString()
        {
            return " RegularCustomer { \n" +
                " Name = " + Name + ", \n" +
                " Contact Number = " + ContactNo + ", \n" +
                " }";
        }
    }
}
