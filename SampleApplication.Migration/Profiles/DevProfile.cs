using FluentMigrator;
using SampleApplication.Migration.Scripts;

namespace SampleApplication.Migration.Profiles
{
    [Profile("dev")]
    public class DevProfile : FluentMigrator.Migration
    {
        public override void Up()
        {
            Execute.Sql(DevProfileScripts.AddEmployees);
        }

        public override void Down()
        {
            //left empty on purpose
        }
    }
}
