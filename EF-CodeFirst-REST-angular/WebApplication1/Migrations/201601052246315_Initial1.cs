namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Goscies", "Telefon", c => c.String(maxLength: 13));
            AddColumn("dbo.Goscies", "Adres", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Goscies", "Adres");
            DropColumn("dbo.Goscies", "Telefon");
        }
    }
}
