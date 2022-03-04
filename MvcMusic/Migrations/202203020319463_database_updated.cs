namespace MvcMusic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class database_updated : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Musics", "Title", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Musics", "Artist", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Musics", "Genre", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Musics", "Genre", c => c.String());
            AlterColumn("dbo.Musics", "Artist", c => c.String());
            AlterColumn("dbo.Musics", "Title", c => c.String());
        }
    }
}
