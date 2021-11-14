using Ejemplo_Capas.Models;
using Ejemplo_Capas.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejemplo_Capas.Repository
{
    public class StudentsRepository: IStudents
    {
        EscuelaDeConexionesEntities1 bd = new EscuelaDeConexionesEntities1();
        public List<Students> ListOfStudents()
        {
            var listadoestudiantes = bd.Students.ToList();
            return listadoestudiantes;


        }
   
    }
}