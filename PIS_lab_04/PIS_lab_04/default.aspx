<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="PIS_lab_04._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #TextArea1 {
            height: 131px;
        }
        #Select1 {
            width: 188px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <input id="Reset" runat="server" type="reset" value="reset"/>
        <input id="Button" runat="server" type="button" onserverclick="Button_ServerClick" value="button" />
        <input id="Submit" runat="server" type="submit" onserverclick="Submit_ServerClick" value="submit" />
        <br />
        <input id="File" runat="server" type="file"/>
        <br />
        <input id="Text" runat="server" type="text" placeholder="text" onserverchange="Text_ServerChange"/>
        <input id="Password" runat="server" type="password" placeholder="password" onserverchange="Text_ServerChange"/>
        <br />
        <input id="Checkbox" runat="server" type="checkbox" onserverchange="Checkbox_ServerChange"/>
        <input id="Radio1" runat="server" type="radio" name="1" onserverchange="Radio1_ServerChange"/>
        <input id="Radio2" runat="server" type="radio" name="1" onserverchange="Radio2_ServerChange"/>
        <br />
        <textarea id="TextArea" runat="server" cols="20" onserverchange="Text_ServerChange"></textarea>
        <br />
        <select id="Select" runat="server" name="D1" onserverchange="Select_ServerChange">
            <option>

            </option>
        </select>
    </div>
    </form>
</body>
</html>
