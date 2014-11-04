using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionRRHH.Modelo;

namespace GestionRRHH
{
    
    class OperacionesRrhh: IOperaciones<Empleado>
    {
        private GestionRRHHEntities db = new GestionRRHHEntities();
        public void Alta(Empleado data)
        {
            db.Empleado.Add(data);
        }

        public void Baja(Empleado data)
        {
            db.Empleado.Remove(data);
        }

        public IEnumerable<Empleado> BusquedaId(int busqueda)
        {
            var buscado = db.Empleado.Where(o => o.idEmpleado == busqueda);
            return buscado;

        }

        public IEnumerable<Empleado> BusquedaSalario(int busqueda)
        {
            var buscado = db.Empleado.Where(o => o.salario >= busqueda);
            return buscado;
        }
    }
}
