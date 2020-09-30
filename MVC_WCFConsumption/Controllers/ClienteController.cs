using MVC_WCFConsumption.ServiceReferenceServicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_WCFConsumption.Controllers
{
    public class ClienteController : Controller
    {
        Service1Client client = new Service1Client();
        // GET: Cliente
        public ActionResult Index()
        {
            var lista = client.viewListClientes();

            return View(lista);
        }

        public ActionResult ClientesActivos()
        {
            var lista = client.viewListClientesActivos();

            return View(lista);
        }
    }
}