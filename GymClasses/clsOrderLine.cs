using System;

namespace GymClasses
{
    public class clsOrderLine
    {
 private String mEquipmentOrdered;      
 public object EquipmentOrdered { 
get 
{
                return mEquipmentOrdered;
}
 
            set {

}


private String mCustomerName;     
 public object CustomerName { 

get 
{
        return mCustomerName;
}

            set {
                mCustomerName = value;
}
            }

                
                
            
       
 


public bool OrderProcessed { get; set; }
        
private DateTime mDateProcessed;
public DateTime DateProcessed { 
get 
                {
              return mDateProcessed;
}
set 
{

       mDateProcessed = value;

}
            }

        


private Int32 mOrderLineNo;
public int OrderNo { 

get
  
          {
return mOrderLineNo;

}

set {
                mOrderLineNo = value;


}
            }
 private int mTotalCost;
public int TotalCost { 

get {
return mTotalCost;
}
    
            set{
mTotalCost = value;

}
        }        
                
                
                
       
 

public bool Find(int OrderLineNo) {

            mOrderLineNo = 5;
            return true;

    }

        public bool Find(int OrderLineNo)
            {
            mOrderLineNo = 5;
            mDateProcessed = Convert.ToDateTime("16/09/2019");
            return true;
            }

        public bool Find(int OrderLineNo)
            {
            mOrderLineNo = 5;
            mTotalCost = 21;
            return true;
}

        public bool Find(int OrderLineNo)
            {
            mOrderLineNo = 5;
            mCustomerName = "Mary Jones";
            return true;
            }




}
}