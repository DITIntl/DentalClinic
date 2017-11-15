using System.ComponentModel.DataAnnotations.Schema;

namespace DentalClinic.DAL.Entities.Core
{
  [Table("SystemRoles", Schema = "core")]
  public class SystemRole
  {
    public int SystemRoleId { get; set; }

    public string RoleName { get; set; }
  }
}
