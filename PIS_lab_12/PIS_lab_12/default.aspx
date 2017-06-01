<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="PIS_lab_12._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/ht<ml; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" ID="lb" />
            <asp:ScriptManager runat="server"></asp:ScriptManager>
            <script>
                var prm = Sys.WebForms.PageRequestManager.getInstance();
                prm.add_initializeRequest(InitializeRequest);

                function InitializeRequest(sender, args) {
                    if (prm.get_isInAsyncPostBack()) {
                        args.set_cancel(true);
                    }
                }

                function AbortPostBack() {
                    if (prm.get_isInAsyncPostBack()) {
                        prm.abortPostBack();
                    }
                }
            </script>
            <asp:UpdatePanel ID="up1" runat="server">
                <ContentTemplate>
                    <asp:TextBox ID="tb1" runat="server"></asp:TextBox>
                    <asp:TextBox ID="tb2" runat="server"></asp:TextBox>
                    <asp:TextBox ID="res" runat="server"></asp:TextBox>
                    <asp:CheckBox ID="modul" runat="server" Text="modul"/>
                    <asp:RadioButtonList ID="op" runat="server">
                        <asp:ListItem Value="0" Text="multi"></asp:ListItem>
                        <asp:ListItem Value="1" Text="plus" Selected="True"></asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:Button ID="mth" runat="server" Text="Button" OnClick="mth_Click"/>
                    <asp:Timer ID="timer" runat="server" Interval="5000" OnTick="timer_Tick"></asp:Timer>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="btr" EventName="Click" />
                </Triggers>
            </asp:UpdatePanel>
            <asp:UpdatePanel ID="up2" runat="server">
                <ContentTemplate>
                    <asp:TextBox ID="tbtest" runat="server"></asp:TextBox>
                    <asp:Button ID="bttest" runat="server" Text="Button" OnClick="bttest_Click"/>
                </ContentTemplate>
                <Triggers>

                </Triggers>
            </asp:UpdatePanel>
            <asp:UpdateProgress runat="server" AssociatedUpdatePanelID="up2">
                <ProgressTemplate>
                    Loading...
                    <input type="button" onclick="AbortPostBack()" value="отмена"/>
                </ProgressTemplate>
            </asp:UpdateProgress>
            <asp:Button runat="server" ID="btr" OnClick="btr_Click" Text="btr"/>
        </div>
    </form>
</body>
</html>
