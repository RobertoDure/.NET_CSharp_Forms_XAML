namespace ControladorDePedidos.Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cpfEcnpj : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Fornecedor", "CNPJ", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Fornecedor", "CNPJ");
        }
    }
}
