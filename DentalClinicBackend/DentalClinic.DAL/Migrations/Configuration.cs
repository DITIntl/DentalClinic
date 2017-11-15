namespace DentalClinic.DAL.Migrations
{
  using DentalClinic.DAL.Entities.Core;
  using System.Data.Entity.Migrations;

  internal sealed class Configuration : DbMigrationsConfiguration<DentalClinic.DAL.DentalClinicContext>
  {
    public Configuration()
    {
      AutomaticMigrationsEnabled = false;
    }

    protected override void Seed(DentalClinicContext context)
    {
      // System roles
      context.SystemRoles.AddOrUpdate(x => x.SystemRoleId, new SystemRole { SystemRoleId = 1, RoleName = "Client" });
      context.SystemRoles.AddOrUpdate(x => x.SystemRoleId, new SystemRole { SystemRoleId = 2, RoleName = "Receptionist" });
      context.SystemRoles.AddOrUpdate(x => x.SystemRoleId, new SystemRole { SystemRoleId = 3, RoleName = "Dentist" });      
    }
  }
}
