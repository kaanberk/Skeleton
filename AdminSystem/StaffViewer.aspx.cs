using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of the class
        clsStaff AnStaff = new clsStaff();
        //get the data from the session project
        AnStaff = (clsStaff)Session["AnStaff"];
        //display the Staff Phone Number
        Response.Write(AnStaff.StaffPhoneNo);
    }
}
    
         