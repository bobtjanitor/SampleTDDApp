using FluentMigrator;
using SampleApplication.Migration.Scripts;

namespace SampleApplication.Migration.Profiles
{
    [Profile("prod")]
    public class ProdProfile : FluentMigrator.Migration
    {
        public override void Up()
        {
            Execute.Sql(ProfileScripts.AddEmployees);
        }

        public override void Down()
        {
            //left empty on purpose
        }
    }
}