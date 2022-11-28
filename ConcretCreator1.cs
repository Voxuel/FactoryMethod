using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class ConcretCreator1 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcretProduct1();
        }
    }
}
