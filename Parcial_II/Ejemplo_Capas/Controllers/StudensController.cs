using Ejemplo_Capas.Models;
using Ejemplo_Capas.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ejemplo_Capas.Controllers
{
    public class StudensController : Controller
    {
        EnrollementsRepository ErollementObjeto = new EnrollementsRepository();
        Erollements erollements = new Erollements();
        CousesRepository cousesRepository = new CousesRepository();
        Courses courses = new Courses();

        

        [HttpGet]
        public ActionResult UnionDeTablas()

        {
            var join = ErollementObjeto.UnionDetablas();

            return View(join);
        }

    }
}