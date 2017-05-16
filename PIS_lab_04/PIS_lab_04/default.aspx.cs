using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace PIS_lab_04 {
    public partial class _default : System.Web.UI.Page {

        HtmlTable table = new HtmlTable();

        protected void Page_Load(object sender, EventArgs e) {

            if (!Page.IsPostBack) {
                Select.Items.Add("1");
                Select.Items.Add("2");
                Select.Items.Add("3"); 
                Select.Items.Add("4");
                Select.Items.Add("5");
                Response.Write("First");
            }
            else
                Response.Write("PostBack");
            
            table.Border = 1;
            table.BorderColor = "red";
            
            HtmlTableRow row = new HtmlTableRow();
            HtmlTableCell cell = new HtmlTableCell();

            cell.InnerHtml = "Html Control";
            row.Cells.Add(cell);
            cell = new HtmlTableCell();
            cell.InnerHtml = "OnServerClick";
            row.Cells.Add(cell);
            cell = new HtmlTableCell();
            cell.InnerHtml = "OnServerChange";
            row.Cells.Add(cell);

            table.Rows.Add(row);

            Controls.Add(table);
        }

        protected void Reset_ServerClick(object sender, EventArgs e) {
            Response.Write("<br />" + ((Control)sender).ID);
        }

        protected void Submit_ServerClick(object sender, EventArgs e) {

            Response.Write("<br />" + ((Control)sender).ID + " - " + sender.GetType().ToString());

            HtmlTableRow row = new HtmlTableRow();
            HtmlTableCell cell = new HtmlTableCell();

            cell.InnerHtml = sender.GetType().ToString();
            row.Cells.Add(cell);
            cell = new HtmlTableCell();
            cell.InnerHtml = "YES";
            row.Cells.Add(cell);
            cell = new HtmlTableCell();
            cell.InnerHtml = "NO";
            row.Cells.Add(cell);

            table.Rows.Add(row);
        }

        protected void Button_ServerClick(object sender, EventArgs e) {
            Response.Write("<br />" + ((Control)sender).ID + " - " + sender.GetType().ToString());

            HtmlTableRow row = new HtmlTableRow();
            HtmlTableCell cell = new HtmlTableCell();

            cell.InnerHtml = sender.GetType().ToString();
            row.Cells.Add(cell);
            cell = new HtmlTableCell();
            cell.InnerHtml = "YES";
            row.Cells.Add(cell);
            cell = new HtmlTableCell();
            cell.InnerHtml = "NO";
            row.Cells.Add(cell);

            table.Rows.Add(row);
        }

        protected void Text_ServerChange(object sender, EventArgs e) {

            if (new HtmlInputText().GetType().Equals(sender.GetType()))
                Response.Write("<br />" + ((Control)sender).ID + " - " + sender.GetType().ToString() + " - " + ((HtmlInputText)sender).Value);
            else if (new HtmlInputPassword().GetType().Equals(sender.GetType()))
                Response.Write("<br />" + ((Control)sender).ID + " - " + sender.GetType().ToString() + " - " + ((HtmlInputPassword)sender).Value);
            else if (new HtmlTextArea().GetType().Equals(sender.GetType()))
                Response.Write("<br />" + ((Control)sender).ID + " - " + sender.GetType().ToString() + " - " + ((HtmlTextArea)sender).Value);

            HtmlTableRow row = new HtmlTableRow();
            HtmlTableCell cell = new HtmlTableCell();

            cell.InnerHtml = sender.GetType().ToString();
            row.Cells.Add(cell);
            cell = new HtmlTableCell();
            cell.InnerHtml = "NO";
            row.Cells.Add(cell);
            cell = new HtmlTableCell();
            cell.InnerHtml = "YES";
            row.Cells.Add(cell);

            table.Rows.Add(row);
        }

        protected void Checkbox_ServerChange(object sender, EventArgs e) {
            Response.Write("<br />" + ((Control)sender).ID + " - " + sender.GetType().ToString());

            HtmlTableRow row = new HtmlTableRow();
            HtmlTableCell cell = new HtmlTableCell();

            cell.InnerHtml = sender.GetType().ToString();
            row.Cells.Add(cell);
            cell = new HtmlTableCell();
            cell.InnerHtml = "NO";
            row.Cells.Add(cell);
            cell = new HtmlTableCell();
            cell.InnerHtml = "YES";
            row.Cells.Add(cell);

            table.Rows.Add(row);
        }

        protected void Radio1_ServerChange(object sender, EventArgs e) {
            Response.Write("<br />" + ((Control)sender).ID + " - " + sender.GetType().ToString());

            HtmlTableRow row = new HtmlTableRow();
            HtmlTableCell cell = new HtmlTableCell();

            cell.InnerHtml = sender.GetType().ToString();
            row.Cells.Add(cell);
            cell = new HtmlTableCell();
            cell.InnerHtml = "NO";
            row.Cells.Add(cell);
            cell = new HtmlTableCell();
            cell.InnerHtml = "YES";
            row.Cells.Add(cell);

            table.Rows.Add(row);
        }

        protected void Radio2_ServerChange(object sender, EventArgs e) {
            Response.Write("<br />" + ((Control)sender).ID + " - " + sender.GetType().ToString());

            HtmlTableRow row = new HtmlTableRow();
            HtmlTableCell cell = new HtmlTableCell();

            cell.InnerHtml = sender.GetType().ToString();
            row.Cells.Add(cell);
            cell = new HtmlTableCell();
            cell.InnerHtml = "NO";
            row.Cells.Add(cell);
            cell = new HtmlTableCell();
            cell.InnerHtml = "YES";
            row.Cells.Add(cell);

            table.Rows.Add(row);
        }

        protected void Select_ServerChange(object sender, EventArgs e) {
            Response.Write("<br />" + ((Control)sender).ID + " - " + sender.GetType().ToString() + " - " + ((HtmlSelect)sender).Value);

            HtmlTableRow row = new HtmlTableRow();
            HtmlTableCell cell = new HtmlTableCell();

            cell.InnerHtml = sender.GetType().ToString();
            row.Cells.Add(cell);
            cell = new HtmlTableCell();
            cell.InnerHtml = "NO";
            row.Cells.Add(cell);
            cell = new HtmlTableCell();
            cell.InnerHtml = "YES";
            row.Cells.Add(cell);

            table.Rows.Add(row);
        }
    }
}