using Microsoft.EntityFrameworkCore;

await using var context = new AppContextFactory().CreateDbContext(Array.Empty<string>());
await context.Database.MigrateAsync();
Console.WriteLine();