namespace C.M_HelpLine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fr : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserComplains",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        number = c.String(),
                        area = c.String(),
                        category = c.String(),
                        details = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserComplains");
        }
    }
}
