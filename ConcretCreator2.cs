using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class ConcretCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcretProduct2();
        }
    }
}
