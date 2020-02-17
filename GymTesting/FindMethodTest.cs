using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GymTesting
{
    [TestClass]
    public class FindMethodTest
    {
        public int EquipmentNo { get; private set; }

        [TestMethod]
        public void FindMethodOK()
        {
            clsEquipment AnEquipment = new clsEquipment();
            Boolean Found = false;
            Int32 EquipmentNo = 1;
            Found = AnEquipment.Find(EquipmentNo);
            Assert.IsTrue(Found);
       
          }

        public void TestEquipmentNoFound()
        {

            clsEquipment AnEquipment = new clsEquipment();
            Boolean Found = false;
            Boolean OK = true;
            Int32 EquipmentNo = 21;
            Found = AnEquipment.Find(EquipmentNo);
            if (AnEquipment.EquipmentNo != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
            public void TestEquipmentDateAdded()
            {
            clsEquipment AnEquipment = new clsEquipment();
            Boolean Found = false;
            Boolean OK = true;
            Int32 EquipmentNo = 21;
            Found = AnEquipment.Find(EquipmentNo);
            if(AnEquipment.EquipmentDateAdded != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            
            }

        }

        public void TestEquipmentDescription()
        {
            clsEquipment AnEquipment = new clsEquipment();
            Boolean Found = false;
            Boolean OK = true;
            Int32 EquipmentNo = 1;
            Found = AnEquipment.Find(EquipmentNo);
            if(AnEquipment.EquipmentDescription != "black")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        public void TestEquipmentColour()
        {
            clsEquipment AnEquipment = new clsEquipment();
            Boolean Found = false;
            Boolean OK = true;
            Int32 EquipmentNo = 1;
            Found = AnEquipment.Find(EquipmentNo);
            if (AnEquipment.EquipmentColour != "black")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        public void TestEquipmentPrice()
        {
            clsEquipment AnEquipment = new clsEquipment();
            Boolean Found = false;
            Boolean OK = true;
            Int32 EquipmentNo = 1;
            Found = AnEquipment.Find(EquipmentNo);
            if (AnEquipment.EquipmentPrice != 2500)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
       
    }




    }


