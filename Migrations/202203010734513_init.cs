namespace C.M_HelpLine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        Number = c.String(),
                        Adhar = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        Comfirm = c.String(),
                        Gender = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
