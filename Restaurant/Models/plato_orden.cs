//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Restaurant.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class plato_orden
    {
        public int idPlatoOrden { get; set; }
        public string tipoPlato { get; set; }
        public string platoOrdenado { get; set; }
        public Nullable<decimal> precioUnitario { get; set; }
        public Nullable<int> cantidad { get; set; }
        public Nullable<decimal> precioCantidad { get; set; }
        public Nullable<int> idOrden { get; set; }
    
        public virtual orden orden { get; set; }
    }
}