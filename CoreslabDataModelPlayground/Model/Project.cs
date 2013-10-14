using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreslabDataModelPlayground.Model
{
    internal sealed class Project
    {
        public Customer Customer { get; private set; }
        public Jobsite Jobsite { get; private set; }
    }
}
