﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class restaurantEntities : DbContext
    {
        public restaurantEntities()
            : base("name=restaurantEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<mesa> mesa { get; set; }
        public virtual DbSet<orden> orden { get; set; }
        public virtual DbSet<plato> plato { get; set; }
        public virtual DbSet<plato_orden> plato_orden { get; set; }
        public virtual DbSet<reservacion> reservacion { get; set; }
        public virtual DbSet<restaurant> restaurant { get; set; }
        public virtual DbSet<tipo_plato> tipo_plato { get; set; }
        public virtual DbSet<tipo_usuario> tipo_usuario { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }
    }
}
