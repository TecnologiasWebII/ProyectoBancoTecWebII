//------------------------------------------------------------------------------
// By Michelle Cortés Pacheco
// creación de BancoModel
//------------------------------------------------------------------------------

namespace ProyectoBancoTecWebII.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BancoBDEntities : DbContext
    {
        public BancoBDEntities()
            : base("name=BancoBDEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cliente> Cliente { get; set; }
    }
}
