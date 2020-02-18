﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GymClasses;

public partial class AnOrderLine : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrderLine anOrderLine = new clsOrderLine();
        anOrderLine = (clsOrderLine)Session["anOrderLine"];
        Response.Write(anOrderLine.OrderNo);
    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }

    protected void BtnOK_Click(object sender, EventArgs e)
    {
        clsOrderLine anOrderLine = new clsOrderLine();
        
        Session["anOrderLine"] = anOrderLine;
        Response.Redirect("OrderLineViewer.aspx");
    }
}