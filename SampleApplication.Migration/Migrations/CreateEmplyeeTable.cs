using System;
using FluentMigrator;

namespace SampleApplication.Migration
{
    //migration number is mased on YYYYMMDDhhmm
    [Migration(201803231125)]
    public class CreateEmplyeeTable : FluentMigrator.Migration
    {
        public override void Up()
        {
            Create.Table("Employees")
                .WithColumn("Id").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("FirstName").AsString().NotNullable()
                .WithColumn("LastName").AsString().NotNullable()
                .WithColumn("City").AsString().NotNullable()
                .WithColumn("State").AsString().NotNullable();
        }

        public override void Down()
        {
            Delete.Table("Employees");
        }
    }
}
