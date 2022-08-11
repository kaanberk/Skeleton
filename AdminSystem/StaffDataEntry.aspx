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
        <asp:TextBox ID="txtStaffId" runat="server" style="z-index: 1; left: 151px; top: 63px; position: absolute" height="25px" width="168px"></asp:TextBox>
        <asp:Label ID="lblStaffDescription" runat="server" style="z-index: 1; left: 9px; top: 91px; position: absolute; height: 166px;" Text="Staff Description" width="168px"></asp:Label>
        <asp:TextBox ID="txtStaffDescription" runat="server" style="z-index: 1; left: 151px; top: 92px; position: absolute" width="168px" height="25px"></asp:TextBox>
        <asp:Label ID="lblStaffId" runat="server" style="z-index: 1; left: 10px; top: 64px; position: absolute" Text="Staff Id" width="168px"></asp:Label>
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 9px; top: 125px; position: absolute" Text="Staff Last Name" width="168px"></asp:Label>
        <asp:Label ID="lblDateJoined" runat="server" style="z-index: 1; left: 9px; top: 158px; position: absolute" Text="Date Joined" width="168px"></asp:Label>
        <p>
            <asp:Label ID="lblStaffSalary" runat="server" style="z-index: 1; left: 9px; top: 191px; position: absolute" Text="Staff Salary" width="168px"></asp:Label>
        </p>
        <asp:TextBox ID="txtStaffLastName" runat="server" style="z-index: 1; left: 151px; top: 126px; position: absolute; bottom: 282px;" height="25px" width="168px"></asp:TextBox>
        <asp:TextBox ID="txtDateJoined" runat="server" style="z-index: 1; left: 151px; top: 156px; position: absolute" height="25px" width="168px"></asp:TextBox>
        <asp:TextBox ID="txtStaffSalary" runat="server" style="z-index: 1; left: 151px; top: 190px; position: absolute" height="25px" width="168px"></asp:TextBox>
        <asp:CheckBox ID="chkStaffAvailable" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" style="z-index: 1; left: 5px; top: 264px; position: absolute" Text="Staff Available" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 8px; top: 300px; position: absolute; height: 19px; margin-bottom: 163px"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 5px; top: 331px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 54px; top: 330px; position: absolute; bottom: 294px" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Label ID="lblStaffPhoneNo" runat="server" style="z-index: 1; left: 6px; top: 222px; position: absolute" Text="Staff Phone No"></asp:Label>
        <asp:TextBox ID="txtStaffPhoneNo" runat="server" style="z-index: 1; left: 151px; top: 223px; position: absolute; height: 28px; width: 171px"></asp:TextBox>
    </form>
</body>
</html>
