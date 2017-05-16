<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="PIS_lab_03_test._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="Access-Control-Allow-Origin" content="*" />
    <meta name="Access-Control-Allow-Headers" content="X-Requested-With" />
    <title></title>
</head>
<body>
    <script type="text/javascript">
        function sum() {
            let oReq = new XMLHttpRequest();
            let x = document.getElementById("x").value;
            let y = document.getElementById("y").value;
            let data = new FormData();
            data.append('x', x);
            data.append('y', y);
            let sUrl = "http://localhost:40305/lab_03/test.msus";
            oReq.open("POST", sUrl, true);
            oReq.send(data);
            oReq.onreadystatechange = function () {
                if (oReq.readyState == 4 && oReq.status == 200) {
                    document.getElementById("z").value = oReq.response;
                }
            }            
        }
    </script>

    <form id="form1" runat="server">
    <div>
        <asp:Button  runat="server" ID="GetButton" text="get" OnClick="GetButton_Click"/>
        <asp:Button  runat="server" ID="PostButton" text="post" OnClick="PostButton_Click"/>
        <asp:Button  runat="server" ID="PutButton" text="put" OnClick="PutButton_Click"/>
        <asp:Button runat="server" ID="ErrorButton" Text="test" OnClick="ErrorButton_Click" />

            <asp:TextBox ID="x" runat="server" ClientIDMode="Static"></asp:TextBox>
            <asp:TextBox ID="y" runat="server" ClientIDMode="Static"></asp:TextBox>
            <asp:TextBox ID="z" runat="server" ReadOnly="True" ClientIDMode="Static"></asp:TextBox>
            <input type="button" value="Ajax" onclick="sum()" id="ButtonAjax" />
    </div>
    </form>    
</body>
</html>
