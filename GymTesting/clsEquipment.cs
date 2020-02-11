using System;

namespace GymTesting
{
    class clsEquipment
    {
        

        public bool Find(int EquipmentNo)
        {
            return true;

       }
        private Int32 mEquipmentNo;
        public Int32 EquipmentNo
        {
            get
            {
                return mEquipmentNo;
            }
            
                set
             {
                mEquipmentNo = value;
                }
            }
        private String mEquipmentDescription;
        public String EquipmentDescription
        {
            get
            {
                return mEquipmentDescription;
            }

            set
            {
                mEquipmentDescription = value;
            }
        }

        private DateTime mEquipmentDateAdded;
        public DateTime EquipmentDateAdded
        {
            get
            {
                return mEquipmentDateAdded;
            }

            set
            {
                mEquipmentDateAdded = value;
            }
        }
        private Int32 mEquipmentPrice;
        public int EquipmentPrice
        {
            get
            {
                return mEquipmentPrice;
            }

            set
            {
                mEquipmentPrice = value;
            }
        }

        private String mEquipmentAvailable;
        public String EquipmentAvailable
        {
            get
            {
                return mEquipmentAvailable;
            }

            set
            {
                mEquipmentAvailable = value;
            }
        }

        public string EquipmentColour { get; internal set; }
    }

    }

