using System;

namespace GymClasses
{
    public class clsOrderLine
    {
        public object EquipmentOrdered { get; set; }
        public object CustomerName { get; set; }
        public bool OrderProcessed { get; set; }
        public DateTime DateOrdered { get; set; }
        public int OrderNo { get; set; }
        public int TotalCost { get; set; }
    }
}