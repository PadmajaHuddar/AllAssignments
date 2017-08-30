namespace ClassLibrary1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDepartmentLib : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.DepartmentLibs", name: "Name", newName: "DeptName");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.DepartmentLibs", name: "DeptName", newName: "Name");
        }
    }
}
