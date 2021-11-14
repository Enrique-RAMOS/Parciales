using Ejemplo_Capas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Capas.Servicios
{
    interface ICurso
    {
        void Create(Courses c);

        void Delete(Courses c);

       

        List<Courses> ListDataCourses();
    }
}
