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
    
    public partial class usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public usuario()
        {
            this.orden = new HashSet<orden>();
        }
    
        public int idUsuario { get; set; }
        public string nombreUsuario { get; set; }
        public string correo { get; set; }
        public Nullable<int> edadUsuario { get; set; }
        public string domicilio { get; set; }
        public Nullable<int> telefonoUsuario { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public Nullable<int> idTipoUsuario { get; set; }
        public Nullable<int> idRestaurant { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orden> orden { get; set; }
        public virtual restaurant restaurant { get; set; }
        public virtual tipo_usuario tipo_usuario { get; set; }
    }
}
