using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GymTesting
{
    [TestClass]
    public class tstcustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            CLSCustomer AnCustomer = new CLSCustomer();
            //test to see that it exits
            Assert.IsNotNull(AnCustomer);
        }
    }
}
