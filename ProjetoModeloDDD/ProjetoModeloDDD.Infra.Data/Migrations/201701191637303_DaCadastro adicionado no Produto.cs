namespace ProjetoModeloDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DaCadastroadicionadonoProduto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produto", "DataCadastro", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Produto", "DataCadastro");
        }
    }
}
