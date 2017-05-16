using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PIS_lab_03.App_Code {
    public class GetHandler : IHttpHandler {

        // можно использовать экземпляр для повторного запроса (если нет, то экземпляр пересоздается)
        public bool IsReusable {
            get {
                return false;
            }
        }

        // обработка запроса, формирование ответа
        public void ProcessRequest(HttpContext context) {
            HttpRequest request = context.Request;
            HttpResponse response = context.Response;
            if (request.QueryString.Count >= 2) {
                string param1 = request.QueryString[0];
                string param2 = request.QueryString[1];
                response.Write("GET-Http-MSU:ParmA = " + param1 + ",ParmB = " + param2);
            }
            else {
                response.Write("GET-Http-MSU");
            }
        }

    }
}