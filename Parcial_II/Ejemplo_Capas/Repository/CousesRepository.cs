using Ejemplo_Capas.Models;
using Ejemplo_Capas.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejemplo_Capas.Repository
{
    public class CousesRepository : ICurso
    {
        EscuelaDeConexionesEntities1 bd = new EscuelaDeConexionesEntities1();

        public void Create(Courses c)
        {
            bd.Courses.Add(c);
            bd.SaveChanges();
        }

        public void Update(Courses c)

        {
            Courses datosactualizados = new Courses();
            datosactualizados = bd.Courses.Find(c.CouserId);

            datosactualizados.Title = c.Title;
            datosactualizados.Credits = c.Credits;
            bd.SaveChanges();
        }

        public void Delete(Courses c)

        {
            c = bd.Courses.Find(c.CouserId);
            _ = c;
            bd.Courses.Remove(c);
            bd.SaveChanges();
        }


        public List<Courses> ListDataCourses()
        {
            var ListOfDataOfCorse = bd.Courses.ToList();
            return ListOfDataOfCorse;
        }
    }
}