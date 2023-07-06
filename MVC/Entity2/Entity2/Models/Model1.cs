using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Entity2.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<record> records { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<record>()
                .Property(e => e.BookName)
                .IsFixedLength();

            modelBuilder.Entity<record>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);
        }
    }
}
