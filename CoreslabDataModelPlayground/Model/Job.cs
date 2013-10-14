using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreslabDataModelPlayground.Model
{
    internal sealed class Job
    {
        public DateTime Date { get; private set; }
        public Project Project { get; private set; }
    }
}
