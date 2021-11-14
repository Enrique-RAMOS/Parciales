using Ejemplo_Capas.Models;
using Ejemplo_Capas.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ejemplo_Capas.Controllers
{
    public class CursosController : Controller
    {
        CousesRepository cousesRepository = new CousesRepository();
        Courses courses = new Courses();

        StudentsRepository studentsRepository = new StudentsRepository();
        Students students = new Students();
        // GET: Cursos
        public ActionResult Index()
        {
            var ListOfDataOfCorse = cousesRepository.ListDataCourses();


            return View(ListOfDataOfCorse);
        }


        [HttpGet]
        public ActionResult ServicioDelete()

        {


            return View();
        }

        [HttpPost]
        public ActionResult ServicioDelete(Courses cursos)

        {
            try
            {
                cousesRepository.Delete(cursos);

            }
            catch
            {


                return Redirect("Error");

            }
            return Redirect("ServicioDelete");
        }

        [HttpGet]
        public ActionResult Combobox()
        {

            var informationStudenst = studentsRepository.ListOfStudents();
            var informationCourses = cousesRepository.ListDataCourses();

            List<SelectListItem> ComboboxOfStudenst = new List<SelectListItem>();
            List<SelectListItem> ComboboxOfcourses = new List<SelectListItem>();

            foreach (var iteracion in informationStudenst)
            {
                ComboboxOfStudenst.Add(new SelectListItem
                {

                    Text = iteracion.FirstMidName,
                    Value = Convert.ToString(iteracion.StudentId)
                });
                ViewBag.listOfStudentscombobox = ComboboxOfStudenst;
            }
            foreach (var iteracion in informationCourses)
            {
                ComboboxOfcourses.Add(new SelectListItem
                {

                    Text = iteracion.Title,
                    Value = Convert.ToString(iteracion.CouserId)
                });
                ViewBag.listOfCoursescombobox = ComboboxOfcourses;
            }
            return View();
        }

        [HttpPost]
        public ActionResult Combobox(String StudentID, String CourseID)
        {
           


            return Redirect("Combobox");



        }
    }
}