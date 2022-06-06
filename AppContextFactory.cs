using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

public class AppContextFactory : IDesignTimeDbContextFactory<AppContext>
{
	private const string ConnectionString = "Server=localhost; Database=Test; User=postgres; Password=postgres; Port=5432; License Key=XXX";

	public AppContext CreateDbContext(string[] args)
	{
		var optionsBuilder = new DbContextOptionsBuilder<AppContext>();
		optionsBuilder.UsePostgreSql(ConnectionString);
		optionsBuilder.EnableDetailedErrors();
		optionsBuilder.EnableSensitiveDataLogging();

		return new AppContext(optionsBuilder.Options);
	}
}