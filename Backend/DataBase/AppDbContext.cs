using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Revngo.Api.models;

namespace Revngo.Api.DataBase;


public class AppDbContext : DbContext
{
    public DbSet<Tour?> Tours => Set<Tour>();
    public DbSet<Room?> Rooms => Set<Room>();
    public DbSet<FilterSection> FilterSections { get; set; }
 
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Tour>()
            .Property(t => t.AcceptedCards)
            .HasConversion(
                v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
                v => JsonSerializer.Deserialize<List<string>>(v, (JsonSerializerOptions)null)
            );
        modelBuilder.Entity<Tour>()
            .Property(t => t.Id)
            .ValueGeneratedNever();
        modelBuilder.Entity<FilterSection>(entity =>
        {
            entity.HasKey(e => e.Key); // Используем Key как первичный ключ, если он уникален

            // Настраиваем коллекцию Items как JSON-колонку
            entity.OwnsMany(e => e.Items, builder =>
            {
                builder.ToJson(); 
            });
        });
        modelBuilder.Entity<Room>()
            .Property(r => r.Id)
            .ValueGeneratedNever(); // База перестанет сама ставить ID

    }
}