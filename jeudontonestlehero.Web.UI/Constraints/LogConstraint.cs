using jeudontonestlehero.Core.Data;

namespace jeudontonestlehero.Web.UI.Constraints
{
    public class LogConstraint : IRouteConstraint
    {
        private readonly DefaultContext _context;
        public LogConstraint(DefaultContext context)
        {
            _context= context;
        }
        public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            bool res = (values["id"]?.ToString() == @"\d+") && (_context.Aventures.First(a => a.Id == (int?)values["id"]) != null);
            return res;
        }
    }
}
