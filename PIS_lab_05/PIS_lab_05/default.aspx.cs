using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PIS_lab_05 {
    public partial class _default : System.Web.UI.Page {
        bool isFirst = true;

        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void Button1_Click(object sender, EventArgs e) {
            TextBox1.Visible = true;
            TextBox1.Text = "1st View";
        }

        protected void Button2_Click(object sender, EventArgs e) {
            TextBox2.Visible = true;
            TextBox2.Text = "2nd View";
        }

        protected void Button3_Click(object sender, EventArgs e) {
            TextBox3.Visible = true;
            TextBox3.Text = "3rd View";
        }

        protected void MainButton_Click(object sender, EventArgs e) {
            MultiView.ActiveViewIndex = (MultiView.ActiveViewIndex + 1) % 3;
            MainButton.Text = "Change View " + (MultiView.ActiveViewIndex + 1);
        }

        protected void RotatorButton_Click(object sender, EventArgs e) {
            if (AdRotator1.KeywordFilter == "")
                AdRotator1.KeywordFilter = "b1";
            else if (AdRotator1.KeywordFilter == "b1")
                AdRotator1.KeywordFilter = "b2";
            else if (AdRotator1.KeywordFilter == "b2")
                AdRotator1.KeywordFilter = "";
            RotatorButton.Text = "Change banner " + AdRotator1.KeywordFilter;
        }

        protected void Wizard_FinishButtonClick(object sender, WizardNavigationEventArgs e) {
            string add_service = "";
            foreach (ListItem add_s in additional_list.Items) {
                if (add_s.Selected)
                    add_service += add_s.Value + " ";
            }
            if (name.Text == "" || surname.Text == "" || father_name.Text == "") finish.Text = "Заполните свои личные данные";
            else if (service_list.SelectedValue == "") finish.Text = "Выберите в какую страну вы бы хотели отправиться";
            else if (new DateTime().ToLongDateString().Contains(day_of_trip.SelectedDate.ToLongDateString())) finish.Text = "Введите дату поездки";
            else if (day_of_trip.TodaysDate.CompareTo(day_of_trip.SelectedDate) > 0) finish.Text = "Вы не можете заказать поездку на это число. Только если вернетесь в прошлое";
            else if (payment_list.SelectedValue == "") finish.Text = "Выберите тип оплаты путешествия";
            else
                finish.Text = name.Text + " " + surname.Text + " " + father_name.Text + " <br /> " +
                service_list.SelectedValue + " <br /> " +
                day_of_trip.SelectedDate.ToLongDateString() + " <br /> " +
                add_service + " <br /> " +
                payment_list.SelectedValue;
        }

        protected void Wizard_CancelButtonClick(object sender, EventArgs e) {
            service_list.ClearSelection();
            name.Text = "";
            surname.Text = "";
            father_name.Text = "";
            service_list.ClearSelection();
            day_of_trip.SelectedDate = new DateTime();
            additional_list.ClearSelection();
            payment_list.ClearSelection();
            Wizard.ActiveStepIndex = 0;
        }

        protected void TreeView_SelectedNodeChanged(object sender, EventArgs e) {
            TreeResult.Text += "Select: "+TreeView.SelectedValue + "<br />";
            isFirst = true;
        }

        protected void TreeView_TreeNodeCheckChanged(object sender, TreeNodeEventArgs e) {
            TreeNodeCollection tree = TreeView.CheckedNodes;
            if (tree.Count > 0 && isFirst) {
                TreeResult.Text += "CheckedCollection: ";
                foreach (TreeNode t in tree) 
                    TreeResult.Text += t.Value + " ";
                TreeResult.Text += "<br />";
                isFirst = false;
            }            
        }

        protected void Menu_MenuItemClick(object sender, MenuEventArgs e) {
            Menu menu = (Menu)sender;
            MenuResult.Text = "select " + menu.SelectedValue;
        }
    }
}