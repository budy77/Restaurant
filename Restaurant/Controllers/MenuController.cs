using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Restaurant.Models;

namespace Restaurant.Controllers
{
    public class MenuController : Controller
    {
        private restaurantEntities db = new restaurantEntities();
        // GET: Menu
        public ActionResult Index()
        {
            var idTiposComidas = (from t in db.tipo_plato select t.idTipoPlato).ToList();
            var tiposComidas = (from tp in db.tipo_plato select tp.tipoPlato).ToList();

            var platos = from p in db.plato where p.estadoPlato == true select p;

            List<string> nombrePlato = new List<string>();
            List<decimal> precioPlato = new List<decimal>();
            List<string> descripcionPlato = new List<string>();
            List<string> imagenplato = new List<string>();
            List<int> idpla = new List<int>();
            foreach (var i in platos)
            {
                nombrePlato.Add(i.plato1);
                precioPlato.Add((decimal)i.precioPlato);
                descripcionPlato.Add(i.descripcionPlato);
                imagenplato.Add(i.imagenPlato);
                idpla.Add((int)i.idTipoPlato);
            }


            ViewBag.idTipos = idTiposComidas;
            ViewBag.tipos = tiposComidas;
            ViewBag.nombrePlato = nombrePlato;
            ViewBag.precioPlato = precioPlato;
            ViewBag.descripcionPlato = descripcionPlato;
            ViewBag.imagenPlato = imagenplato;
            ViewBag.idPla = idpla;
            return View();
        }
    }
}