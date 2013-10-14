using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreslabDataModelPlayground.Model
{
    internal sealed class JobAssignment
    {
        public Job Job { get; private set; }
        public Employee Employee { get; private set; }
        public Product Product { get; private set; }
    }
}
