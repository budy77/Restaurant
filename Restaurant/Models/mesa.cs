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
    
    public partial class mesa
    {
        public int idMesa { get; set; }
        public Nullable<int> numeroMesa { get; set; }
        public Nullable<int> estadoMesa { get; set; }
        public Nullable<int> idRestaurant { get; set; }
    
        public virtual restaurant restaurant { get; set; }
    }
}
