using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AnStaff = new clsStaff();
        //capture the house no
        String StaffPhoneNo = txtStaffPhoneNo.Text;
        //store the address in the session object
        Session["AnStaff"] = AnStaff;
        //navigate to the viewer page
        Response.Redirect("StaffViewer.aspx");

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AnStaff = new clsStaff();
        //capture the house no
        String StaffPhoneNo = txtStaffPhoneNo.Text;
        //store the address in the session object
        Session["AnStaff"] = AnStaff;
        //navigate to the viewer page
        Response.Redirect("StaffViewer.aspx");
    }
}