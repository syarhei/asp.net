<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="PIS_lab_08.Student" %>
<%@ Register TagPrefix="msu" TagName="ctrl" Src="~/StudentUC.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type="text/javascript">
        
        function HandleResult(arg, context) {
            label.innerHTML = arg;
        }

        function getValues() {
            var mas = new Array();
            mas.push(document.getElementById('ctl06_name').value);
            mas.push(document.getElementById('ctl06_sname').value);
            mas.push(document.getElementById('ctl06_fname').value);
            mas.push(document.getElementById('ctl06_bday').value);
            if (document.getElementById('ctl06_sex_0').checked) mas.push("М");
            if (document.getElementById('ctl06_sex_1').checked) mas.push("Ж");
            mas.push(document.getElementById('ctl06_faculty').value);
            mas.push(document.getElementById('ctl06_group').value);
            mas.push(document.getElementById('ctl06_year').value);

            return mas[0] + "#" + mas[1] + "#" + mas[2] + "#" + mas[3] + "#" + mas[4] + "#" + mas[5] + "#" + mas[6] + "#" + mas[7];
        }
    </script>

    <style type="text/css">
        #Button1 {
            height: 33px;
            width: 127px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager runat="server"></asp:ScriptManager>
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <msu:ctrl runat="server" SurName="Murkou" Group="10" Input="Ввод"></msu:ctrl>
                    <input id="Button1" type="button" value="Call" onclick="CallServer(getValues());"/><br/>
                    <label id="label"></label>
                </ContentTemplate>
            </asp:UpdatePanel>
            
        </div>
    </form>
</body>
</html>