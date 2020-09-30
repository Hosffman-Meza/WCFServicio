using MVC_WCFConsumption.ServiceReferenceServicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_WCFConsumption.Controllers
{
    public class UbicacionController : Controller
    {
        Service1Client client = new Service1Client();
        // GET: Ubicacion
        public ActionResult Index()
        {
            var lista = client.viewListUbicacion();
            
            return View(lista);
        }
    }
}