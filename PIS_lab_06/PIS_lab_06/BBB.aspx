<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BBB.aspx.cs" Inherits="PIS_lab_06.BBB" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="BBB" runat="server">
        <p>
            <asp:TextBox ID="name" runat="server" ValidationGroup="v1"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" Text="Имя"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="surname" runat="server" ValidationGroup="v1"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Фамилия"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="patronymic" runat="server" ValidationGroup="v1"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text="Отчество"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="mail" runat="server" ValidationGroup="v2"></asp:TextBox>
            <asp:Label ID="Label4" runat="server" Text="Почта"></asp:Label>
        </p>
         <p>
            <asp:TextBox ID="sum" runat="server" ValidationGroup="v2"></asp:TextBox>
             <asp:Label ID="Label5" runat="server" Text="Сумма"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="bday" runat="server" ValidationGroup="v2"></asp:TextBox>
            <asp:Label ID="Label6" runat="server" Text="Дата рождения"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="pass" TextMode="Password" runat="server" ValidationGroup="v2"></asp:TextBox>
            <asp:Label ID="Label7" runat="server" Text="Пароль"></asp:Label>
        </p>

        <asp:Button ID="Button1" runat="server" Text="Button 1" ValidationGroup="v1"/>
        <asp:Button ID="Button2" runat="server" Text="Button 2" ValidationGroup="v2"/>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="v1"/>
        <asp:ValidationSummary ID="ValidationSummary2" runat="server" ValidationGroup="v2"/>

        <asp:RegularExpressionValidator ID="RegularExpressionValidatorName" runat="server"
        ErrorMessage="Введите имя [только кирилица] "
        ControlToValidate="name" Display="None" ValidationExpression="^[а-яА-ЯёЁъЪ]+$"
        ValidationGroup="v1"></asp:RegularExpressionValidator>

        <asp:RegularExpressionValidator ID="RegularExpressionValidatorSurname" runat="server"
        ErrorMessage="Введите фамилию [только кирилица] "
        ControlToValidate="surname" Display="None" ValidationExpression="^[а-яА-ЯёЁъЪ]+$"
        ValidationGroup="v1"></asp:RegularExpressionValidator>

        <asp:RegularExpressionValidator ID="RegularExpressionValidatorPatronymic" runat="server"
        ErrorMessage="Введите отчество [только кирилица] "
        ControlToValidate="patronymic" Display="None" ValidationExpression="^[а-яА-ЯёЁъЪ]+$"
        ValidationGroup="v1"></asp:RegularExpressionValidator>

        <asp:RegularExpressionValidator ID="RegularExpressionValidatorMail" runat="server" 
        ErrorMessage="Невалидный адресс" ControlToValidate="mail" ValidationGroup="v2"
        Display="None" ValidationExpression="\S+@\S+\.\S+"></asp:RegularExpressionValidator>
        
        <asp:RangeValidator ID="RangeValidatorSum" runat="server" 
        ControlToValidate="sum" Display="None" 
        ErrorMessage="Сумма должна быть в пределах [1000, 2000]" MaximumValue="2000" 
        MinimumValue="1000" Type="Integer" ValidationGroup="v2"></asp:RangeValidator>

        <asp:RangeValidator ID="RangeValidatorBDay" runat="server" 
        ControlToValidate="bday" Display="None" 
        ErrorMessage="до 2017 года" MaximumValue="01.01.2017" 
        MinimumValue="01.01.0001" Type="Date" ValidationGroup="v2"></asp:RangeValidator>
        
        <asp:CustomValidator ID="CustomValidatorPass" runat="server" ErrorMessage="Введие пароль из неповторяющхся символов"
        ControlToValidate="pass" Display="None" ClientValidationFunction="CustomValidatorPass_ServerValidate"
        OnServerValidate="CustomValidatorPass_ServerValidate" ValidationGroup="v2">
        </asp:CustomValidator>            
    </form>
</body>
</html>
