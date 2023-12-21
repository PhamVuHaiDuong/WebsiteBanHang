namespace WebsiteBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1512 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_Subscribe", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_Subscribe", "Name", c => c.String());
        }
    }
}
