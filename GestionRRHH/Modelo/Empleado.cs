//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionRRHH.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Empleado
    {
        public int idEmpleado { get; set; }
        public string nombre { get; set; }
        public string dni { get; set; }
        public int idCargoEmp { get; set; }
        public decimal salario { get; set; }
    
        public virtual Cargo Cargo { get; set; }
    }
}
