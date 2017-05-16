using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PIS_lab_03.App_Code {
    public class PostHandler : IHttpHandler {
        public bool IsReusable {
            get {
                return false;
            }
        }

        public void ProcessRequest(HttpContext context) {
            HttpRequest request = context.Request;
            HttpResponse response = context.Response;
            if (request.Form.Count >= 2) {
                string param1 = request.Form[0];
                string param2 = request.Form[1];
                response.Write("POST-Http-MSU:ParmA = " + param1 + ",ParmB = " + param2);
            }
            else {
                response.Write("POST-Http-MSU");
            }
        }
    }
}