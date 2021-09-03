namespace RodDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Moto : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Motoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Modelo = c.String(),
                        Marca = c.String(),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Motoes");
        }
    }
}
