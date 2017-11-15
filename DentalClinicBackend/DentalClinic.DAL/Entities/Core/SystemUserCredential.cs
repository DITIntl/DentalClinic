using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DentalClinic.DAL.Entities.Core
{
  [Table("SystemUserCredential", Schema = "core")]
  public class SystemUserCredential
  {
    public int SystemUserCredentialId { get; set; }

    public string Login { get; set; }

    public string Password { get; set; }

    public Guid Salt { get; set; }

    public bool IsActive { get; set; }

    // Navigation properties
    public virtual SystemUser SystemUser { get; set; }
  }
}
