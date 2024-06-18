using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace APIREST.Controllers
{
    public class BUSESController : Controller
    {
        private BUSESNEGOCIO _busesNegocio;

        public BUSESController()
        {
            _busesNegocio = new BUSESNEGOCIO();
        }

        // GET: BUSES
        public ActionResult Index()
        {
            var buses = _busesNegocio.ObtenerBuses();
            return View(buses);
        }

        // GET: BUSES/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var bus = _busesNegocio.ObtenerBuses().FirstOrDefault(b => b.ID_Bus == id);
            if (bus == null)
            {
                return HttpNotFound();
            }
            return View(bus);
        }

        // GET: BUSES/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BUSES/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_Bus,NumUnidadBus,Marca,Modelo,Capacidad_Pasajeros")] Buses bus)
        {
            if (ModelState.IsValid)
            {
                _busesNegocio.AgregarBus(bus);
                return RedirectToAction("Index");
            }
            return View(bus);
        }

        // GET: BUSES/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var bus = _busesNegocio.ObtenerBuses().FirstOrDefault(b => b.ID_Bus == id);
            if (bus == null)
            {
                return HttpNotFound();
            }
            return View(bus);
        }

        // POST: BUSES/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_Bus,NumUnidadBus,Marca,Modelo,Capacidad_Pasajeros")] Buses bus)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _busesNegocio.ActualizarBus(bus);
                }
                catch
                {
                    if (!_busesNegocio.ObtenerBuses().Any(b => b.ID_Bus == bus.ID_Bus))
                    {
                        return HttpNotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(bus);
        }

        // GET: BUSES/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var bus = _busesNegocio.ObtenerBuses().FirstOrDefault(b => b.ID_Bus == id);
            if (bus == null)
            {
                return HttpNotFound();
            }
            return View(bus);
        }

        // POST: BUSES/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var bus = _busesNegocio.ObtenerBuses().FirstOrDefault(b => b.ID_Bus == id);
            if (bus == null)
            {
                return HttpNotFound();
            }
            _busesNegocio.EliminarBus(id);
            return RedirectToAction("Index");
        }
    }
}
