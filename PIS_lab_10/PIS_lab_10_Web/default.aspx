<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="PIS_lab_10_Web._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>service</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            X:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxX" runat="server"></asp:TextBox>
            <br />
            Y:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID="TextBoxY" runat="server"></asp:TextBox>
            <br />
            RESULT:&nbsp;
            <asp:TextBox ID="TextBoxRes" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="BtnAdd" runat="server" Text="+" OnClick="BtnAdd_Click" />
            <asp:Button ID="BtnSub" runat="server" Text="-" OnClick="BtnSub_Click" style="height: 26px" />
            <asp:Button ID="BtnMul" runat="server" Text="*" OnClick="BtnMul_Click" />
            <br />
            <br />
            SESSION<br />
            Value:
            <asp:TextBox ID="TextBoxSessionValue" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="BtnGet" runat="server" Text="Get" OnClick="BtnGet_Click" />
            <asp:Button ID="BtnSet" runat="server" Text="Set" OnClick="BtnSet_Click" />
            <br />
            <br />
            <asp:Button ID="btnHistory" runat="server" OnClick="btnHistory_Click" Text="Update history" />
        </div>
        <asp:TextBox ID="TextBoxHistory" runat="server" Height="236px" TextMode="MultiLine" Width="301px"></asp:TextBox>
    </form>
</body>
</html>
