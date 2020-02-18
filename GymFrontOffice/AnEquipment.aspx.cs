using System;
using GymClasses;

public partial class AnEquipment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsEquipment AnEquipment = new clsEquipment();
        AnEquipment = (clsEquipment)Session["AnEquipment"];
        Response.Write(AnEquipment.EquipmentColour);
    }
}

