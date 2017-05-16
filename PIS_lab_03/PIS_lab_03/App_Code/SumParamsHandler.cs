using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PIS_lab_03.App_Code {
    public class SumParamsHandler : IHttpHandler {
        public bool IsReusable {
            get {
                return false;
            }
        }

        public void ProcessRequest(HttpContext context) {
            HttpRequest request = context.Request;
            HttpResponse response = context.Response;
            if (request.Params.Count >= 2) {
                int x, y;
                if (int.TryParse(request.Params[0], out x) && int.TryParse(request.Params[1], out y)) {
                    int sum = x + y;
                    response.Write(sum);
                }
                else {
                    response.Write("Put only digits");
                }
            }
            else {
                response.Write("Put 2 params");
            }
        }
    }
}