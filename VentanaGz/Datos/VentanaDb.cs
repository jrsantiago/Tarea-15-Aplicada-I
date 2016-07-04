using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.Entity;

namespace Datos
{
    public partial class DbVentanaGzEntities : DbContext
    {
        public DbVentanaGzEntities()
            : base("name=DbVentanaGzEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
          //  throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Usuario> Usuario { get; set; }
    }
}
