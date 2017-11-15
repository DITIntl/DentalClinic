using DentalClinic.DAL.Entities.Core;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DentalClinic.DAL.Entities.Dmn
{
  [Table("Visits", Schema = "dmn")]
  public class Visit
  {
    public int VisitId { get; set; }

    public int ClientId { get; set; }

    public int DentistId { get; set; }

    public DateTime? Date { get; set; }

    public bool IsCanceled { get; set; }

    // Navigation properties
    public virtual SystemUser Client { get; set; }

    public virtual SystemUser Dentist { get; set; }
  }
}
