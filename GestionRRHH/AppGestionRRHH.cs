using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
            IOperaciones<Empleado> ope = new OperacionesRrhh();
            int codigo = 0;

            do
            {
                Console.WriteLine("fjdkaslfj");
                Int32.TryParse(Console.ReadLine(), out codigo);

                switch (codigo)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    default:
                        break;
                }

            } while (codigo != 4);

        }

        private static void Alta(IOperaciones<Empleado> ope)
        {
            Console.WriteLine("Nombre Empleado");
            var n = Console.ReadLine();
            Console.WriteLine("DNI");
            var dni = Console.ReadLine();
            Console.WriteLine("Cargo: ");
            foreach (var cargo in db.Cargo)
            {
                if (cargo != null) Console.Write(" {0}. {1}",cargo.idCargo, cargo.nombre);
            }
            var c = 0;
            Int32.TryParse(Console.ReadLine(), out c);
            Console.WriteLine("Salario");
            var s = 12500;
            Int32.TryParse(Console.ReadLine(), out s);

            var Emple = new Empleado()
            {
                nombre = n,
                dni = dni,
                idCargoEmp = c,
                salario = s,
            };

            ope.Alta(Emple);
        }

        private static void Baja(IOperaciones<Empleado> ope)
        {
            Console.WriteLine("Metodo de busqueda: 1. Id. 2. Nombre. 3. DNI.");
            var valor = 1;
            Int32.TryParse(Console.ReadLine(), out valor);

            switch (valor)
            {
                case 1:
                    var id = 0;
                    Console.WriteLine("Introduce Id: ");
                    Int32.TryParse(Console.ReadLine(), out id);

                    var emple = db.Empleado.Where(o => o.idEmpleado == id);

                    ope.Baja(emple);
                    break;
                case 2:
                    Console.WriteLine("Introduce Nombre: ");
                    
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default:
                    break;
            }


        }

        private static void BusquedaId(IOperaciones<Empleado> ope)
        {
            

            Console.WriteLine("Usuario a buscar por Id.");
            var id = 0;
            Int32.TryParse(Console.ReadLine(), out id);

            ope.BusquedaId(id);



        }









    }
}
