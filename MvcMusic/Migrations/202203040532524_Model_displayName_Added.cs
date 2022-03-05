namespace MvcMusic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Model_displayName_Added : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Musics", "Artist", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Musics", "Artist", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
