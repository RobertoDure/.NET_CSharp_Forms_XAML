namespace ControladorDePedidos.Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NomeDaMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cliente", "CPF", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cliente", "CPF");
        }
    }
}
