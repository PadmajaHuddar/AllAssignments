namespace ClassLibrary1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddURL : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DepartmentLibs", "AddURL", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.DepartmentLibs", "AddURL");
        }
    }
}
