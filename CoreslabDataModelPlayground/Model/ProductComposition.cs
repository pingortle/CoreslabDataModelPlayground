using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreslabDataModelPlayground.Model
{
    internal sealed class ProductComposition
    {
        public Product Parent { get; private set; }
        public Product Child { get; private set; }
        public int Quantity { get; private set; }
    }
}
