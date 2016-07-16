using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SalonbeautyWeb.Controllers
{
    public class HomeController : Controller //heranças
    {

        //ações
        public ActionResult Index()
        {
            return View();
        }

        //acoe
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AcaoDeTeste()
        {

            ViewBag.Mensagem = "Mensagem de teste para a minha visao";

            ViewBag.DataHora = DateTime.Now.ToLongTimeString();

            return View();
        }

    }
}