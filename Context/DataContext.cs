using Microsoft.EntityFrameworkCore;
using myApp.Models;
using System.Configuration;

namespace myApp.Context;

public class DataContext:DbContext
{

    public DataContext()
    {
        
    }

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }
    
    public virtual DbSet<Human> Humans { get; set; }
    
  

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        =>optionsBuilder.UseNpgsql(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder: modelBuilder);
        modelBuilder.Entity<Human>().ToTable("humans");
    }
}