..\packages\FluentMigrator.1.6.2\tools\Migrate.exe /connection "Server=tcp:xxxxxxxxxxxxxx,1433;Initial Catalog=SampleApplication;Persist Security Info=False;User ID=xxxxxxxxxx;Password=xxxxxxxx;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;" /db sqlserver /target ./bin/SampleApplication.Migration.dll /profile dev 