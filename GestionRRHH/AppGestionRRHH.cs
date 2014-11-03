using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionRRHH.Modelo;

namespace GestionRRHH
{
    class AppGestionRrhh
    {
        static GestionRRHHEntities db = new GestionRRHHEntities();
        static void Main(string[] args)
        {
            

        }

        /*public static IEnumerable<Empleado> GetEmpleadoById(int idEmp)
        {
            var datos = db.Empleado.Where(o => o.idEmpleado == idEmp).OrderBy(o => o.nombre);

            return datos;
        }

        public static IEnumerable<Cargo> GetCargoById(int idCarg)
        {
            var datos = db.Cargo.Where(o => o.idCargo == idCarg);

            return datos;
        } */




    }
}
