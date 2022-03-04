namespace MvcMusic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class database_created : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Musics",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Artist = c.String(),
                        ReleaseDate = c.DateTime(nullable: false),
                        Genre = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Musics");
        }
    }
}
