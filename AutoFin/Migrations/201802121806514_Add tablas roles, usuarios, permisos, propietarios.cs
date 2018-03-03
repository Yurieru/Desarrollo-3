namespace AutoFin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addtablasrolesusuariospermisospropietarios : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Permisos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Propietarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, unicode: false),
                        Apellidos = c.String(nullable: false, unicode: false),
                        Telefono = c.String(unicode: false),
                        Email = c.String(nullable: false, unicode: false),
                        Fotografia = c.String(unicode: false),
                        esBorrado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false, unicode: false),
                        Password = c.String(nullable: false, unicode: false),
                        EsBorrado = c.Boolean(nullable: false),
                        Nombre = c.String(nullable: false, unicode: false),
                        Apellidos = c.String(nullable: false, unicode: false),
                        Rol_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.Rol_Id)
                .Index(t => t.Rol_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuarios", "Rol_Id", "dbo.Roles");
            DropIndex("dbo.Usuarios", new[] { "Rol_Id" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Roles");
            DropTable("dbo.Propietarios");
            DropTable("dbo.Permisos");
        }
    }
}
