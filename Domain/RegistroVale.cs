using System.Collections;
using System;
using System.Collections.Generic;
using Scm.Domain;
using System.Linq;

namespace CargaDescarga {
    public class RegistroVale
    {
        public int IdRegistroVale { get; set; }
        public DateTime Fecha  { get; set; }
        /// <summary>
        /// Total sin aplicar retenciones
        /// </summary>
        /// <returns></returns>
        public decimal GetSubTotalVale() { 
            decimal suma = 0.0M;
            if(Vales!=null && Vales.Count>0){

                foreach(var value in Vales)
                suma += value.Monto;
            }
            // Vales.Select(x=>suma=x.Monto);

            return suma;
         }
        //public Retenciones Retenciones {get;set;}
        public Empleado Empleado {get; set;}
        public List<Vale> Vales{get;set;}
        public AppUser Usuario {get; set;}
        
        //Adecuaciones por entity framework
        public int IdEmpleado { get; set; }
        public string UsuarioId { get; set; }
    }
}