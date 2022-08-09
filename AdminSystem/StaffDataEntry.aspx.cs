using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    public object txtStaffPhoneNo { get; private set; }
    public object textStaffPhoneNo { get; private set; }

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
        //capture the Staff Number
        AnStaff.StaffPhoneNo = lblStaffPhoneNo.Text;
        //store the address in the session object
        Session["AnStaff"] = AnStaff;
        //navigate to the viewer page
        Response.Redirect("StaffViewer.aspx");

    }
       //creatr a new instance of clsStaff 
       clsStaff AnStaff = new clsStaff();
       //capture the Staff Id
       AnStaff.StaffId = lblStaffId.Text;
       //store the address in the session object
       Session["AnStaff"] = AnStaff;
       //navigate to the viewer page
       Response.Redirect("StaffViewer.aspx);





}