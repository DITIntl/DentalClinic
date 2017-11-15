using System.ComponentModel.DataAnnotations.Schema;

namespace DentalClinic.DAL.Entities.Dmn
{
  [Table("Comments", Schema = "dmn")]
  public class Comment
  {
    public int CommentId { get; set; }

    public int VisitId { get; set; }

    public string Text { get; set; }

    public bool IsRead { get; set; }

    // Navigation property
    public virtual Visit Visit { get; set; }
  }
}
