using System.Threading.Tasks;
using System.Web.Mvc;
using BaseServicios;
using ClienteApiVehiculos.Models;
using Microsoft.Practices.Unity;

namespace ClienteApiVehiculos.Controllers
{
    public class TipoController : Controller
    {
        // GET: Tipo
        [Dependency]
        public IServiciosRest<TipoVehiculo> Servicio { get; set; }
         
        public ActionResult Index()
        {
            var data = Servicio.Get();
            return View(data);
        }

        public async Task<ActionResult> Alta()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Alta(TipoVehiculo model)
        {
            var data = await Servicio.Add(model);

            return RedirectToAction("Index");
        }
    }
}