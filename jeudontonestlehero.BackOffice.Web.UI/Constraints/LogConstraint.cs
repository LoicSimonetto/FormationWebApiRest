namespace jeudontonestlehero.BackOffice.Web.UI.Constraints
{
    public class LogConstraint : IRouteConstraint
    {
        public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            return values["id"]?.ToString() == "1";
        }
    }
}
