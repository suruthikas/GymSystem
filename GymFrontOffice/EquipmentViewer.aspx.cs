using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GymClasses;
public partial class AnEquipmentViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsEquipment AnEquipment = new clsEquipment();
        AnEquipment = (clsEquipment)Session["AnEquipment"];
        Response.Write(AnEquipment.EquipmentAvailable);
    }
}