namespace HandsOnWork01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bulas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(unicode: false),
                        Apresentacao = c.String(unicode: false),
                        Uso = c.String(unicode: false),
                        Composicao = c.String(unicode: false),
                        Indicacao = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Bulas");
        }
    }
}
