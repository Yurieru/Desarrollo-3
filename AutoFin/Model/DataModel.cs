namespace AutoFin.Model
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DataModel : DbContext
    {
 

      public DbSet<Usuario> Usuarios { get; set; }
      public DbSet<Rol> Roles { get; set; }
      public DbSet<Permiso> Permisos { get; set; }
      public DbSet<Propietario> Propietarios { get; set; }
      public DbSet<PermisoNegado> Permisosnegados { get; set; }
      public DbSet<Auto> Autos { get; set; }
      public DbSet<Venta> Ventas { get; set; }
      public DbSet<Promocion> Promociones { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }

   
}