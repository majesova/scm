using System.Collections;
using System;
using System.Collections.Generic;
using Scm.Domain;

namespace CargaDescarga {
    public class RegistroVale
    {
        public int IdRegistroVale { get; set; }
        public DateTime Fecha  { get; set; }
        public decimal TotalVale { get; set; }
        public Retenciones retenciones;
        public Empleado empleado;
        public List<Vale> Vales;
        public AppUser usuario {get; set;}
        
        //Adecuaciones por entity framework
    }
}