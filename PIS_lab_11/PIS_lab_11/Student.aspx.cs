using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PIS_lab_08 {
    public partial class Student : System.Web.UI.Page, ICallbackEventHandler {

        //protected void Page_Load(object sender, EventArgs e) {
        //}

        private string _tempVar;

        // Обработка события обратного вызова (обработка отправленн данных)
        public void RaiseCallbackEvent(string eventArgument) {
            var mas = eventArgument.Split('#');
            _tempVar = "OK";
            foreach (var param in mas)
                if (string.Equals(param, "undefined") || string.Equals(param, "")) {
                    _tempVar = "error: не все поля заполнены!";
                    return;
                }
            if (Convert.ToInt32(mas[6]) > 100 || Convert.ToInt32(mas[6]) < 0) {
                _tempVar = "error: номер группы не в диапазоне [0;100]";
            }
        }

        // возвращает результат события
        public string GetCallbackResult() {
            return "Server check result: " + _tempVar;
        }

        protected void Page_Load(object sender, EventArgs e) {
            var cm = Page.ClientScript;
            // метод (получает ряд параметров, генерирует клиентск код)
            var cbReference = cm.GetCallbackEventReference(this, "arg", "HandleResult", "");

            var cbScript = "function CallServer(arg, context){" + cbReference + ";}";
            cm.RegisterClientScriptBlock(GetType(), "CallServer", cbScript, true); // регистрация
        }
    }
}