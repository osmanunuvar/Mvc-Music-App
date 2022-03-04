namespace MvcMusic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class database_updated2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Musics", "Title", c => c.String(nullable: false, maxLength: 60));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Musics", "Title", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
