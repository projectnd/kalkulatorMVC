using Kalkulator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kalkulator.Controllers
{
    public class KalkulatorController : Controller
    {
        // GET: Kalkulator
        public ActionResult Index()
        {
            //string model = "Dobar dan Koprivnica";
            //string[] model2 = new string[] { "Dobar", "dan", "Koprivnica" };
            return View();

        }
        public ActionResult Kalkulator(KalkulatorModel model)
        {
            switch (model.Operacija)
            {
                case Operacija.Zbrajanje:
                    model.Rezultat = model.PrviOperand + model.DrugiOperand;
                    break;
                case Operacija.Oduzimanje:
                    model.Rezultat = model.PrviOperand - model.DrugiOperand;
                    break;
                case Operacija.Mnozenje:
                    model.Rezultat = model.PrviOperand * model.DrugiOperand;
                    break;
                case Operacija.Dijeljenje:
                    model.Rezultat = model.PrviOperand / model.DrugiOperand;
                    break;
            }
            return View("Index", model);
        }
    }
}