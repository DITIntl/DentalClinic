namespace DentalClinic.DAL
{
  using DentalClinic.DAL.Entities.Core;
  using DentalClinic.DAL.Entities.Dmn;
  using DentalClinic.DAL.Entities.Usr;
  using System.Data.Entity;

  public class DentalClinicContext : DbContext
  {
    public DentalClinicContext()
        : base("name=DentalClinicContext")
    {
      Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DentalClinicContext>());
    }

    public virtual DbSet<SystemRole> SystemRoles { get; set; }

    public virtual DbSet<SystemUser> SystemUsers { get; set; }

    public virtual DbSet<SystemUserCredential> SystemUserCredentials { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Visit> Visits { get; set; }

    public virtual DbSet<Comment> Comments { get; set; }

    public virtual DbSet<Suggestion> Suggestions { get; set; }
  }
}
