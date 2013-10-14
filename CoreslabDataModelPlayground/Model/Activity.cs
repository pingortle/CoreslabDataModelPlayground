using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreslabDataModelPlayground.Model
{
    internal class Activity
    {
        public Product Product { get; private set; }
        public TimeSpan EstimatedLength { get; private set; }
    }
}
