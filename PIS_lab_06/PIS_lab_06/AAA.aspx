<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AAA.aspx.cs" Inherits="PIS_lab_06.AAA" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        RequiredFieldValidator <br />
        <div>
            <asp:TextBox ID="TextBox1" runat="server" ValidationGroup="Group1"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Text="RequiredFieldValidator: input data" ControlToValidate="TextBox1" ValidationGroup="Group1">
            </asp:RequiredFieldValidator> <br />
            <asp:DropDownList ID="DropDownList1" runat="server" ValidationGroup="Group1"></asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Text="RequiredFieldValidator: select item" ControlToValidate="DropDownList1" ValidationGroup="Group1">
            </asp:RequiredFieldValidator> <br />
            <asp:Button ID="Button1" runat="server" Text="Button" ValidationGroup="Group1" />
        </div>
        <br />
        RangeValidator int [100,200] date [01.01.2011,31.12.2011]
        <br />
        <div>
            <asp:TextBox ID="TextBox2" runat="server" ValidationGroup="Group2"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" runat="server" Text="RangeValidator: int [100,200]" ControlToValidate="TextBox2" MaximumValue="200" MinimumValue="100" ToolTip="Введите число от 100 до 200" ValidationGroup="Group2" Type="Integer"></asp:RangeValidator> <br />
            <asp:TextBox ID="TextBox3" runat="server" ValidationGroup="Group2"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator2" runat="server" Text="RangeValidator: date [01.01.2011,31.12.2011]" ControlToValidate="TextBox3" MaximumValue="31.12.2011" MinimumValue="01.01.2011" ValidationGroup="Group2" Type="Date"></asp:RangeValidator> <br />
            <asp:Button ID="Button2" runat="server" Text="Button" ValidationGroup="Group2" />
        </div>
        <br />
        CompareValidator [1<2]
        <br />
        <div>
            <asp:TextBox ID="TextBox4" runat="server" ValidationGroup="g3"></asp:TextBox>
            <asp:TextBox ID="TextBox5" runat="server" ValidationGroup="g3"></asp:TextBox>
            <asp:Button ID="Button3" runat="server" Text="Button" ValidationGroup="g3" />
            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="CompareValidator: [1<2] : false" ControlToValidate="TextBox4" ControlToCompare="TextBox5" Type="Date" ValidationGroup="g3" Operator="LessThan">
            </asp:CompareValidator>
        </div>
        <br />
        RegularExpressionValidator [email]
        <br />
        <div>
            <asp:TextBox ID="TextBox6" runat="server" ValidationGroup="g4"></asp:TextBox>
            <asp:Button ID="Button4" runat="server" Text="Button" ValidationGroup="g4"/>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="RegularExpressionValidator: invalid email" ControlToValidate="TextBox6" ValidationGroup="g4" ValidationExpression="\S+@\S+\.\S+"></asp:RegularExpressionValidator>
        </div>
        <br />
        CustomValidator [simple digit]
        <br />
        <div>
            <asp:TextBox ID="TextBox7" runat="server" ValidationGroup="g5"></asp:TextBox>
            <asp:Button ID="Button5" runat="server" Text="Button" ValidationGroup="g5"/>
            <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="CustomValidator: invalid simple digit" ValidationGroup="g5" ControlToValidate="TextBox7" ClientValidationFunction="isSimple" EnableClientScript="True" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
        </div>        
    </div>
    </form>
</body>
</html>
