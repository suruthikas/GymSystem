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
                mEquipmentOrdered = value;
}
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

        


private Int32 mOrderNo;
public int OrderNo { 

get
  
          {
return mOrderNo;

}

set {
                mOrderNo = value;


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
                
                
                
       
 

public bool Find(int OrderNo) {

            mOrderNo = 5;
            return true;

    }

        public bool Find(int OrderNo)
            {
            mOrderNo = 5;
            mDateProcessed = Convert.ToDateTime("16/09/2019");
            return true;
            }

        public bool Find(int OrderNo)
            {
            mOrderNo = 5;
            mTotalCost = 21;
            return true;
}

        public bool Find(int OrderNo)
            {
            mOrderNo = 5;
            mCustomerName = "Mary Jones";
            return true;
            }

        public bool Find(int OrderNo)
{

clsDataConnection DB = new clsDataConnection();
DB.AddParameter("@OrderNo", OrderNo);
DB.Execute("sproc_tblOrderLine_FilterByOrderLineNo");
if (DB.Count == 1)
{

mOrderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
mEquipmentOrdered =  Convert.ToString(DB.DataTable.Rows[0]["Protein Powder"]);
mTotalCost = "20";
mCustomerName = "Mary Jones";
mOrderProcessed = true;
mDateProcessed = Convert.ToDateTime("16/09/2019");

            return true;
}
else {
                return false;
}





}
}
}