using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Synaptica.Shared.Models;

[Table("instructor")]
public class Instructor {
    [Key]
    [Column("instructorId")]
    public int InstructorId { get; set;}

    [Column("name")]
    public string? Name { get; set; }

    [Column("email")]
    public string? Email { get; set; }
}