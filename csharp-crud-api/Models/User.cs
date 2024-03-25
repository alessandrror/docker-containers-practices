using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
  [Table("users")]
  public class User
  {
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    public int Name { get; set; }

    [Column("email")]
    public int Email { get; set; }
  }
}