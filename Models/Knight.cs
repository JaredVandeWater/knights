using System;
using System.ComponentModel.DataAnnotations;

namespace knights.Models
{
  public class Knight
  {
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Weapon { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

  }
}