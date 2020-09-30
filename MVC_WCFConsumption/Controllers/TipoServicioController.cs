using MVC_WCFConsumption.Models;
using MVC_WCFConsumption.ServiceReferenceServicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_WCFConsumption.Controllers
{
    public class TipoServicioController : Controller
    {
        Service1Client client = new Service1Client();
        // GET: TipoServicio
        public ActionResult Index()
        {
            var lista = client.viewListTipoServicio();

            return View(lista);
        }

        public ActionResult insertTipoServicio()
        {
            return View();
        }

        [HttpPost]
        public ActionResult insertTipoServicio(TipoServicioCLS oTpioServicioCLS)
        {
            client.insertTipoServicio(oTpioServicioCLS.Descripcion, oTpioServicioCLS.Estado);
            
            return RedirectToAction("Index");
        }

        public ActionResult updateTipoServicio(int idTS)
        {
            TipoServicioCLS xTipoServicioCLS = new TipoServicioCLS();
            
            //int idTS = 100;
            var item = client.selectOneTipoServicio(idTS);

            xTipoServicioCLS.IdTipoServicio = item.IdTipoServicio;
            xTipoServicioCLS.Descripcion = item.Descripcion;
            xTipoServicioCLS.Estado = item.Estado;

            return View(xTipoServicioCLS);
        }

        [HttpPost]
        public ActionResult updateTipoServicio(TipoServicioCLS xTipoServicioCLS)
        {
            int st = 0;

            st = (int)client.updateTipoServicio(xTipoServicioCLS.IdTipoServicio, xTipoServicioCLS.Descripcion, xTipoServicioCLS.Estado).estado;

            return RedirectToAction("Index");
        }

        public ActionResult deleteTipoServicio(int idTS)
        {
            TipoServicioCLS dTipoServicioCLS = new TipoServicioCLS();

            //int idTS = 100;
            var item = client.selectOneTipoServicio(idTS);

            dTipoServicioCLS.IdTipoServicio = item.IdTipoServicio;
            dTipoServicioCLS.Descripcion = item.Descripcion;
            dTipoServicioCLS.Estado = item.Estado;

            return View(dTipoServicioCLS);
        }

        [HttpPost]
        public ActionResult deleteTipoServicio(TipoServicioCLS dTipoServicioCLS)
        {
            int st = 0;

            st = (int)client.deleteTipoServicio(dTipoServicioCLS.IdTipoServicio).estado;

            return RedirectToAction("Index");
        }
    }
}