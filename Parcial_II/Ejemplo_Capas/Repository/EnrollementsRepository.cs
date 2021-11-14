using Ejemplo_Capas.Models;
using Ejemplo_Capas.Servicios;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ejemplo_Capas.Repository
{
    public class EnrollementsRepository : IEnrollement
    {
        EscuelaDeConexionesEntities1 bd = new EscuelaDeConexionesEntities1();
        public List<Erollements> UnionDetablas()
        {
            var ConsultaJoin = bd.Erollements.Include(e => 
            e.Students).Include(c=>c.Courses).ToList();
            return ConsultaJoin;
        }
    }
}