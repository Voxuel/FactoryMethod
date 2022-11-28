using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public abstract class Creator
    {
        public abstract IProduct FactoryMethod();


        public string SomeOperator()
        {
            var pro = FactoryMethod();

            var result = "Creator : The same creator code has worked with " +
                pro.Operation();

            return result;
        }
    }
}
