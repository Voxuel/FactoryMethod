using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class Client
    {
        public void Start()
        {
            Console.WriteLine("App : Lanched with the ConcreteCreator 1 ");
            ClientCode(new ConcretCreator1());

            Console.WriteLine("App : Lanched with the ConcreteCreator 2 ");
            ClientCode(new ConcretCreator2());
        }


        public void ClientCode(Creator cr)
        {
            Console.WriteLine("Client: I am aware of the creator class, " + "But I still works. \n" +
                cr.SomeOperator());
        }
    }
}
