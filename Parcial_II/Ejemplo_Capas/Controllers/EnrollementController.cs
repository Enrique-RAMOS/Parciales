using Ejemplo_Capas.Models;
using Ejemplo_Capas.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ejemplo_Capas.Controllers
{
    public class EnrollementController : Controller
    {
        // GET: Enrollement

        CousesRepository cousesRepository = new CousesRepository();
         Courses courses = new Courses();
       

        [HttpGet]
        public ActionResult Registrar()

        {


            return View();
        }

        [HttpPost]
        public ActionResult Registrar(Courses cursos)

        {
            cousesRepository.Create(cursos);

            return Redirect("Registrar");
        }

    }
}