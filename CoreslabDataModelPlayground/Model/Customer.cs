using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreslabDataModelPlayground.Model
{
    class Customer
    {
        public string ID { get; private set; }
        public string Name { get; private set; }
        public string Location { get; private set; }
        public string Plan { get; private set; }
    }
}
