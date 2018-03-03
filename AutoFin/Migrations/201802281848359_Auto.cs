namespace AutoFin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Auto : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Autos",
                c => new
                    {
                        AutoId = c.Int(nullable: false, identity: true),
                        NumeroSerie = c.String(nullable: false, unicode: false),
                        Modelo = c.String(nullable: false, unicode: false),
                        Anio = c.String(nullable: false, unicode: false),
                        Marca = c.String(nullable: false, unicode: false),
                        Placa = c.String(unicode: false),
                        Descripcion = c.String(nullable: false, unicode: false),
                        Fotografia = c.String(unicode: false),
                        esVendido = c.Boolean(nullable: false),
                        Precio = c.Double(nullable: false),
                        Propietario_PropetiarioId = c.Int(),
                    })
                .PrimaryKey(t => t.AutoId)
                .ForeignKey("dbo.Propietarios", t => t.Propietario_PropetiarioId)
                .Index(t => t.Propietario_PropetiarioId);
            
            CreateTable(
                "dbo.Promociones",
                c => new
                    {
                        PromocionId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, unicode: false),
                        Descuento = c.Int(nullable: false),
                        FechaInicio = c.DateTime(nullable: false, precision: 0),
                        FechaFinal = c.DateTime(nullable: false, precision: 0),
                        Auto_AutoId = c.Int(),
                    })
                .PrimaryKey(t => t.PromocionId)
                .ForeignKey("dbo.Autos", t => t.Auto_AutoId)
                .Index(t => t.Auto_AutoId);
            
            CreateTable(
                "dbo.Propietarios",
                c => new
                    {
                        PropetiarioId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, unicode: false),
                        Apellidos = c.String(nullable: false, unicode: false),
                        Telefono = c.String(unicode: false),
                        Email = c.String(nullable: false, unicode: false),
                        Fotografia = c.String(unicode: false),
                        esBorrado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PropetiarioId);
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        AutoId = c.Int(nullable: false),
                        Fecha = c.DateTime(nullable: false, precision: 0),
                        Precio = c.Double(nullable: false),
                        Descuento = c.Double(nullable: false),
                        Usuario_UsuarioId = c.Int(),
                    })
                .PrimaryKey(t => t.AutoId)
                .ForeignKey("dbo.Autos", t => t.AutoId)
                .ForeignKey("dbo.Usuarios", t => t.Usuario_UsuarioId)
                .Index(t => t.AutoId)
                .Index(t => t.Usuario_UsuarioId);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        UsuarioId = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false, unicode: false),
                        Password = c.String(nullable: false, unicode: false),
                        EsBorrado = c.Boolean(nullable: false),
                        Nombre = c.String(nullable: false, unicode: false),
                        Apellidos = c.String(nullable: false, unicode: false),
                        Rol_RolId = c.Int(),
                    })
                .PrimaryKey(t => t.UsuarioId)
                .ForeignKey("dbo.Roles", t => t.Rol_RolId)
                .Index(t => t.Rol_RolId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RolId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.RolId);
            
            CreateTable(
                "dbo.PermisosNegados",
                c => new
                    {
                        PermisonegadoId = c.Int(nullable: false, identity: true),
                        Permiso_PermisoId = c.Int(),
                        Rol_RolId = c.Int(),
                    })
                .PrimaryKey(t => t.PermisonegadoId)
                .ForeignKey("dbo.Permisos", t => t.Permiso_PermisoId)
                .ForeignKey("dbo.Roles", t => t.Rol_RolId)
                .Index(t => t.Permiso_PermisoId)
                .Index(t => t.Rol_RolId);
            
            CreateTable(
                "dbo.Permisos",
                c => new
                    {
                        PermisoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.PermisoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ventas", "Usuario_UsuarioId", "dbo.Usuarios");
            DropForeignKey("dbo.Usuarios", "Rol_RolId", "dbo.Roles");
            DropForeignKey("dbo.PermisosNegados", "Rol_RolId", "dbo.Roles");
            DropForeignKey("dbo.PermisosNegados", "Permiso_PermisoId", "dbo.Permisos");
            DropForeignKey("dbo.Ventas", "AutoId", "dbo.Autos");
            DropForeignKey("dbo.Autos", "Propietario_PropetiarioId", "dbo.Propietarios");
            DropForeignKey("dbo.Promociones", "Auto_AutoId", "dbo.Autos");
            DropIndex("dbo.PermisosNegados", new[] { "Rol_RolId" });
            DropIndex("dbo.PermisosNegados", new[] { "Permiso_PermisoId" });
            DropIndex("dbo.Usuarios", new[] { "Rol_RolId" });
            DropIndex("dbo.Ventas", new[] { "Usuario_UsuarioId" });
            DropIndex("dbo.Ventas", new[] { "AutoId" });
            DropIndex("dbo.Promociones", new[] { "Auto_AutoId" });
            DropIndex("dbo.Autos", new[] { "Propietario_PropetiarioId" });
            DropTable("dbo.Permisos");
            DropTable("dbo.PermisosNegados");
            DropTable("dbo.Roles");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Ventas");
            DropTable("dbo.Propietarios");
            DropTable("dbo.Promociones");
            DropTable("dbo.Autos");
        }
    }
}
