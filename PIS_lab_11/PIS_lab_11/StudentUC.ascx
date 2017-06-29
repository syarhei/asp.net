<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="StudentUC.ascx.cs" Inherits="PIS_lab_08.StudentUC" %>

<asp:TextBox ID="sname" runat="server" placeholder="фамилия"></asp:TextBox> <br />
<asp:TextBox ID="name" runat="server" placeholder="имя"></asp:TextBox> <br />
<asp:TextBox ID="fname" runat="server" placeholder="отчество"></asp:TextBox> <br />
<asp:TextBox ID="bday" runat="server" placeholder="день рождения"></asp:TextBox> <br />
<asp:Label runat="server">Пол:</asp:Label> <br />
<asp:RadioButtonList ID="sex"  runat="server" RepeatDirection="Horizontal">
<asp:ListItem ID="M" value="1" runat="server" Text="муж" />
<asp:ListItem ID="W" value="0" runat="server" Text="жен" />
</asp:RadioButtonList> <br />
<asp:Label runat="server">Факультет:</asp:Label>
<asp:DropDownList ID="faculty" runat="server">
 <asp:ListItem Value="ФИТ"></asp:ListItem>
 <asp:ListItem Value="ИДиП"></asp:ListItem>
 <asp:ListItem Value="ИЭФ"></asp:ListItem>
</asp:DropDownList> <br />
<asp:TextBox ID="group" runat="server" placeholder="группа [0,100]"></asp:TextBox><br />
<asp:TextBox ID="year" runat="server" placeholder="год поступления"></asp:TextBox><br />
<asp:Button ID="input"  UseSubmitBehavior="false"  runat="server" />
<asp:Button ID="cancel"  UseSubmitBehavior="false" CausesValidation="false" runat="server" Text="Отказаться" />

<asp:RequiredFieldValidator ID="RequiredFieldValidatorSName" runat="server" ErrorMessage="Введите фамилию"
 ControlToValidate="sname" Display="None"></asp:RequiredFieldValidator>
<asp:RequiredFieldValidator ID="RequiredFieldValidatorGroup" runat="server" ErrorMessage="Введите номер группы"
 ControlToValidate="group" Display="None"></asp:RequiredFieldValidator>
<asp:RangeValidator ID="RangeValidatorGroup" runat="server" ErrorMessage="Номер группы 1-100"
 ControlToValidate="group" MaximumValue="100" MinimumValue="1" Type="Integer" Display="None">
</asp:RangeValidator>
<asp:ValidationSummary ID="ValidationSummary1" runat="server" />