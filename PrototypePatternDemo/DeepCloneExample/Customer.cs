using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatternDemo.DeepCloneExample
{
    public abstract class Customer
    {
        private string name;
        private string contactNo;

        public string Name {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string ContactNo
        {
            get
            {
                return contactNo;
            }
            set
            {
                contactNo = value;
            }
        }

        public abstract Customer DeepClone();
        public abstract Customer ShallowClone();
    }
}
