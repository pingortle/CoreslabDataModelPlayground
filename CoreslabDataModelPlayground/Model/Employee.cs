using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreslabDataModelPlayground.Model
{
    internal sealed class Employee
    {
        public int SSN { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}
