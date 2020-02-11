using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GymTesting
{
    [TestClass]
    public class tstEquipment
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsEquipment AnEquipment = new clsEquipment();
            //test to see that it exits
            Assert.IsNotNull(AnEquipment);
        }
    }
}
