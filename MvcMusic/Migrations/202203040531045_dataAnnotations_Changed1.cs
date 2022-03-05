namespace MvcMusic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dataAnnotations_Changed1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Musics", "Genre", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Musics", "Genre", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
