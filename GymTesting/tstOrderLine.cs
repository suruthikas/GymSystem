using System;
using GymClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GymTesting
{
    [TestClass]
    public class tstOrderLine
    {
        [TestMethod]
        public void InstanceOK()
        {
            ClsOrderLine AnOrder = new ClsOrderLine();
            Assert.IsNotNull(AnOrder);





        }
    }
}
