using System.ComponentModel.DataAnnotations.Schema;

namespace DentalClinic.DAL.Entities.Dmn
{
  [Table("Suggestions", Schema = "dbo")]
  public class Suggestion
  {
    public int SuggestionId { get; set; }

    public int VisitId { get; set; }

    public string Text { get; set; }

    // Navigation properties
    public virtual Visit Visit { get; set; }
  }
}
