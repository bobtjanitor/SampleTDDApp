using FluentMigrator;
using SampleApplication.Migration.Scripts;

namespace SampleApplication.Migrations
{
    [Migration(201804231339)]
    public class UpdateEmplyeeTable : FluentMigrator.Migration
    {
        public override void Up()
        {
            //using a resource file for holding sql scripts 
            Execute.Sql(UpScripts.UpdateEmplyees);
        }

        public override void Down()
        {
            Delete.Column("Phone").FromTable("Employees");
        }
    }
}