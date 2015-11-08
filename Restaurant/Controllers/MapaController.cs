using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Restaurant.Models;

namespace Restaurant.Controllers
{
    public class MapaController : Controller
    {
        private restaurantEntities bd = new restaurantEntities();
        // GET: Mapa
        public ActionResult Index()
        {
            List<int> idRestaurant = new List<int>();
            List<string> nombres = new List<string>();
            List<decimal> latitud = new List<decimal>();
            List<decimal> longitud = new List<decimal>();

            var restaurant = from r in bd.restaurant  select r;
            foreach (var o in restaurant)
            {
                idRestaurant.Add(o.idRestaurant);
                nombres.Add(o.nombreRestaurant);
                latitud.Add((decimal)o.latitud);
                longitud.Add((decimal)o.longitud);
            }

            ViewBag.id = idRestaurant;
            ViewBag.nombres = nombres;
            ViewBag.latitud = latitud;
            ViewBag.longitud = longitud;
            return View();
        }
    }
}