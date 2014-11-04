using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRRHH
{
    public interface IOperaciones<Tipo>
    {
        //Se crean los métodos que van a ser usados para trabajar con la app de gestion RRHH.
        /*
         *Se requiere:
         * - Alta de Empleados
         * - Baja de Empleados
         * - Buscar Empleado por Id
         * - Buscar Empleado por Salario
         */
        void Alta(Tipo data);
        void Baja(Tipo data);
        IEnumerable<Tipo> BusquedaId(int busqueda);
        IEnumerable<Tipo> BusquedaSalario(int busqueda);

    }

}
