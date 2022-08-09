<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 77px; top: 59px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblStaffDescription" runat="server" style="z-index: 1; left: 9px; top: 91px; position: absolute; height: 166px;" Text="Staff Description" width="168px"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 152px; top: 92px; position: absolute" width="168px"></asp:TextBox>
        <asp:Label ID="lblStaffId" runat="server" style="z-index: 1; left: 10px; top: 64px; position: absolute" Text="Staff Id" width="168px"></asp:Label>
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 9px; top: 125px; position: absolute" Text="Staff Last Name" width="168px"></asp:Label>
        <asp:Label ID="lblDateJoined" runat="server" style="z-index: 1; left: 9px; top: 158px; position: absolute" Text="Date Joined" width="168px"></asp:Label>
        <p>
            <asp:Label ID="lblStaffSalary" runat="server" style="z-index: 1; left: 9px; top: 191px; position: absolute" Text="Staff Salary" width="168px"></asp:Label>
        </p>
        <asp:Label ID="lblStaffPhoneNo" runat="server" style="z-index: 1; left: 8px; top: 226px; position: absolute" Text="Staff Phone No" width="168px"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 147px; top: 126px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 118px; top: 156px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox5" runat="server" style="z-index: 1; left: 118px; top: 190px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox7" runat="server" style="z-index: 1; left: 175px; top: 224px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkStaffAvailable" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" style="z-index: 1; left: 5px; top: 264px; position: absolute" Text="Staff Available" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 8px; top: 300px; position: absolute; height: 19px; margin-bottom: 163px"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 5px; top: 331px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 54px; top: 330px; position: absolute; bottom: 294px" Text="Cancel" />
    </form>
</body>
</html>
