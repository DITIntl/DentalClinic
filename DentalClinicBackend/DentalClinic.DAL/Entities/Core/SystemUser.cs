using System.ComponentModel.DataAnnotations.Schema;

namespace DentalClinic.DAL.Entities.Core
{
  [Table("SystemUsers", Schema = "core")]
  public class SystemUser
  {
    public int SystemUserId { get; set; }

    public int SystemRoleId { get; set; }

    public string Name { get; set; }

    public string Surname { get; set; }

    // Navigation properties
    public virtual SystemRole SystemRole { get; set; }
  }
}
