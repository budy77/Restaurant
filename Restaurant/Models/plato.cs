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
    
    public partial class plato
    {
        public int idPlato { get; set; }
        public string plato1 { get; set; }
        public Nullable<decimal> precioPlato { get; set; }
        public string descripcionPlato { get; set; }
        public string imagenPlato { get; set; }
        public Nullable<bool> estadoPlato { get; set; }
        public Nullable<int> idTipoPlato { get; set; }
        public Nullable<int> idRestaurant { get; set; }
    
        public virtual restaurant restaurant { get; set; }
        public virtual tipo_plato tipo_plato { get; set; }
    }
}
