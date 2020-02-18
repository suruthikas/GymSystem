using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class AnEquipment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsEquipment AnEquipment = new clsEquipment();
        AnEquipment = (clsEquipment)Session["AnEquipment"];
        Response.Write(AnEquipment.EquipmentNo);
    }
}

