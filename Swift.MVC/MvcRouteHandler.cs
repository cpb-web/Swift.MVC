using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Routing;

namespace Swift.MVC
{
    /// <summary>
    /// 自定义了一个实现IRouteHandler的类型，用来返回处理请求的HttpHandler是哪个
    /// </summary>
    public class MvcRouteHandler : IRouteHandler
    {
        public System.Web.IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            return new MvcHandler();
        }
    }
}
