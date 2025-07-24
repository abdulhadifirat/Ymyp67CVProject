using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Ymyp67CVProjectEntity.Concrete;

namespace Ymyp67CVProjectDataAccess.Contexts;

public sealed class Ymyp67CVProjectDbContext : DbContext
{
    //public Ymyp67CVProjectDbContext(DbContextOptions<Ymyp67CVProjectDbContext> options) : base(options)
    //{ }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=FIRAT\SQLEXPRESS; Initial Catalog=Ymyp67CVDb; Integrated Security=True; Trust Server Certificate=True");

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
    
    public DbSet<About> Abouts { get; set; }
    public DbSet<Certificate> Certificates { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Education> Educations { get; set; }
    public DbSet<Experience> Experiences { get; set; }
    public DbSet<Interest> Interests { get; set; }
    public DbSet<Language> Languages{ get; set; }
    public DbSet<PersonalInfo> PersonalInfos{ get; set; }
    public DbSet<Skill> Skills { get; set; }
    public DbSet<SocialAccount> SocialAccounts { get; set; }

}
