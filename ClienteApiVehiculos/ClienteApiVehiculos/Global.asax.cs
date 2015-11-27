using System.Web.Mvc;
using System.Web.Routing;
using ClienteApiVehiculos.App_Start;

namespace ClienteApiVehiculos
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            // Cuando arranque la aplicación, se activa la inyección de UNITY
            UnityWebActivator.Start();
        }
    }
}
