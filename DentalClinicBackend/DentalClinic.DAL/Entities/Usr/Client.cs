using DentalClinic.DAL.Entities.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DentalClinic.DAL.Entities.Usr
{
  [Table("Clients", Schema = "usr")]
  public class Client
  {
    [Key]
    public int SystemUserId { get; set; }

    public DateTime? DateOfBirth { get; set; }

    // navigation properties
    public virtual SystemUser SystemUser { get; set; }
  }
}
