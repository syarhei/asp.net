<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="PIS_lab_05._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="FFE" runat="server">
        
        <div>
            <asp:MultiView ID="MultiView" runat="server" ActiveViewIndex="0">
            
                <asp:View ID="View1" runat="server">
                    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click"/>
                    <asp:TextBox ID="TextBox1" runat="server" Visible="false" ReadOnly="True"></asp:TextBox> <br />
                    <asp:Wizard ID="Wizard" runat="server" DisplayCancelButton="True" FinishPreviousButtonText="Назад" Height="300px" StartNextButtonText="Дальше" StepNextButtonText="Дальше" StepPreviousButtonText="Назад" ActiveStepIndex="0" Width="500px" BackColor="#F7F6F3" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Consolas" Font-Size="Medium" OnFinishButtonClick="Wizard_FinishButtonClick" OnCancelButtonClick="Wizard_CancelButtonClick">
                        <HeaderStyle BackColor="#5D7B9D" BorderStyle="Solid" Font-Bold="True" Font-Size="0.9em" ForeColor="White" HorizontalAlign="Left" />
                        <NavigationButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
                        <SideBarButtonStyle BorderWidth="0px" Font-Names="Verdana" ForeColor="White" />
                        <SideBarStyle BackColor="#7C6F57" BorderWidth="0px" Font-Size="0.9em" VerticalAlign="Top" />
                        <StepStyle BorderWidth="0px" ForeColor="#5D7B9D" />
                        <WizardSteps>
                            <asp:WizardStep ID="personal_data" runat="server" Title="ФИО">
                                <asp:TextBox ID="name" runat="server" Font-Names="Consolas" Font-Size="12pt"></asp:TextBox> <br />
                                <asp:TextBox ID="surname" runat="server" Font-Names="Consolas" Font-Size="12pt"></asp:TextBox> <br />
                                <asp:TextBox ID="father_name" runat="server" Font-Names="Consolas" Font-Size="12pt"></asp:TextBox>
                            </asp:WizardStep>
                            <asp:WizardStep ID="service" runat="server" Title="Выбор услуги">
                                <asp:RadioButtonList ID="service_list" runat="server" >
                                    <asp:ListItem Text="Терапевт" ></asp:ListItem>
                                    <asp:ListItem Text="Окулист" ></asp:ListItem>
                                    <asp:ListItem Text="Стоматолог" ></asp:ListItem>
                                    <asp:ListItem Text="Эндокринолог" ></asp:ListItem>
                                </asp:RadioButtonList>
                                
                            </asp:WizardStep>
                            <asp:WizardStep ID="date" runat="server" Title="Дата">
                                <asp:Calendar ID="day_of_trip" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Consolas" Font-Size="Large" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="340px" Caption="Календарь" NextPrevFormat="FullMonth">

                                    <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                                    <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                                    <OtherMonthDayStyle ForeColor="#CC9966" />
                                    <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                                    <SelectorStyle BackColor="#FFCC66" />
                                    <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                                    <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />

                                </asp:Calendar>
                            </asp:WizardStep>
                            <asp:WizardStep ID="additional" runat="server" Title="Доп услуги">
                                <asp:CheckBoxList ID="additional_list" runat="server" Font-Names="Consolas" Font-Size="12pt">
                                    <asp:ListItem Text="Солярий" ></asp:ListItem>
                                    <asp:ListItem Text="Массаж" ></asp:ListItem>
                                    <asp:ListItem Text="Физеотерапия" ></asp:ListItem>
                                    <asp:ListItem Text="Гидротерапия" ></asp:ListItem>
                                </asp:CheckBoxList>
                            </asp:WizardStep>
                            <asp:WizardStep ID="payment" runat="server" Title="Тип оплаты">
                                <asp:ListBox ID="payment_list" runat="server" Height="81px" Font-Names="Consolas" Font-Size="12pt">
                                    <asp:ListItem Text="Qiwi"></asp:ListItem>
                                    <asp:ListItem Text="WebMoney"></asp:ListItem>
                                    <asp:ListItem Text="Cash"></asp:ListItem>
                                </asp:ListBox>
                            </asp:WizardStep>
                            <asp:WizardStep ID="confirmation" runat="server" Title="Подтверждение">
                                <asp:Label ID="finish" runat="server" Text=""></asp:Label>
                            </asp:WizardStep>
                        </WizardSteps>
                    </asp:Wizard>
                </asp:View>

                <asp:View ID="View2" runat="server">
                    <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click"/>
                    <asp:TextBox ID="TextBox2" runat="server" Visible="false" ReadOnly="True"></asp:TextBox> <br />
                    <asp:Label ID="TreeResult" runat="server" Text=""></asp:Label>
                    <asp:TreeView ID="TreeView" runat="server" ImageSet="News" NodeIndent="10" OnSelectedNodeChanged="TreeView_SelectedNodeChanged" OnTreeNodeCheckChanged="TreeView_TreeNodeCheckChanged">
                        <HoverNodeStyle Font-Underline="True" />
                        <Nodes>
                            <asp:TreeNode Text="1" ToolTip="Корень 1 уровня" Value="1" Expanded="True" ImageUrl="~/Resources/tree1.png">
                                <asp:TreeNode Text="1.1" Value="1.1" ToolTip="Корень 2 уровня" ImageUrl="~/Resources/tree1.png">
                                    <asp:TreeNode Text="1.1.1" Value="1.1.1" ShowCheckBox="true" ToolTip="Листок" ImageUrl="~/Resources/tree1.png"></asp:TreeNode>
                                    <asp:TreeNode Text="1.1.2" Value="1.1.2" ShowCheckBox="true" ToolTip="Листок" ImageUrl="~/Resources/tree2.png"></asp:TreeNode>
                                </asp:TreeNode>
                                <asp:TreeNode Text="1.2" Value="1.2" ToolTip="Корень 2 уровня" ImageUrl="~/Resources/tree2.png">
                                    <asp:TreeNode Text="1.2.1" Value="1.2.1" ShowCheckBox="true" ToolTip="Листок" ImageUrl="~/Resources/tree1.png"></asp:TreeNode>
                                </asp:TreeNode>
                            </asp:TreeNode>
                        </Nodes>
                        <NodeStyle Font-Names="Arial" Font-Size="10pt" ForeColor="Black" HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
                        <ParentNodeStyle Font-Bold="False" />
                        <SelectedNodeStyle Font-Underline="True" HorizontalPadding="0px" VerticalPadding="0px" />
                    </asp:TreeView>
                </asp:View>

                <asp:View ID="View3" runat="server">
                    <asp:Button ID="Button3" runat="server" Text="Button" OnClick="Button3_Click"/>
                    <asp:TextBox ID="TextBox3" runat="server" Visible="false" ReadOnly="True"></asp:TextBox> <br />
                    <asp:Menu ID="Menu" runat="server" BackColor="#F7F6F3" DynamicHorizontalOffset="2" Font-Names="Consolas" Font-Size="Large" ForeColor="#7C6F57" OnMenuItemClick="Menu_MenuItemClick" StaticSubMenuIndent="10px">
                        <DynamicHoverStyle BackColor="#7C6F57" ForeColor="White" />
                        <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                        <DynamicMenuStyle BackColor="#F7F6F3" />
                        <DynamicSelectedStyle BackColor="#5D7B9D" />
                        <Items>
                            <asp:MenuItem Text="A" Value="A">
                                <asp:MenuItem Text="AA" Value="AA">
                                    <asp:MenuItem Text="AAA1" Value="AAA1"></asp:MenuItem>
                                    <asp:MenuItem Text="AAA2" Value="AAA2"></asp:MenuItem>
                                    <asp:MenuItem Text="AAA3" Value="AAA3"></asp:MenuItem>
                                </asp:MenuItem>
                            </asp:MenuItem>
                            <asp:MenuItem Text="B" Value="B">
                                <asp:MenuItem Text="BB" Value="BB">
                                    <asp:MenuItem Text="BBB1" Value="BBB1"></asp:MenuItem>
                                </asp:MenuItem>
                            </asp:MenuItem>
                            <asp:MenuItem Text="C" Value="C">
                                <asp:MenuItem Text="CC" Value="CC"></asp:MenuItem>
                            </asp:MenuItem>
                            <asp:MenuItem Text="D" Value="D"></asp:MenuItem>
                        </Items>
                        <StaticHoverStyle BackColor="#7C6F57" ForeColor="White" />
                        <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                        <StaticSelectedStyle BackColor="#5D7B9D" />
                    </asp:Menu>
                    <asp:Label ID="MenuResult" runat="server" Text=""></asp:Label>
                </asp:View>
                        
            </asp:MultiView>

            <br />
            <asp:Button ID="MainButton" runat="server" Text="Next View" OnClick="MainButton_Click"/>

        </div>
        <div>
            <br /> <br />
            <asp:Button ID="RotatorButton" runat="server" Text="Change Banner" OnClick="RotatorButton_Click" /> <br /> <br />
            <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/Resources/file.xml" />
        </div>
    </form>
</body>
</html>
