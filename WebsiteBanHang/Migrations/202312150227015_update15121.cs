namespace WebsiteBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update15121 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Subscribe", "Email", c => c.String(nullable: false));
            DropColumn("dbo.tb_Subscribe", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_Subscribe", "Name", c => c.String(nullable: false));
            DropColumn("dbo.tb_Subscribe", "Email");
        }
    }
}
