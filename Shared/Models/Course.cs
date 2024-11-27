using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Synaptica.Shared.Models;

[Table("course")]
public class Course {
	[Key]
	[Column("courseId")]
	public int CourseId { get; set;}

    [Column("title")]
    public string? Title { get; set; }

    [Column("description")]
    public string? Description { get; set; }

    [Column("duration")]
    public string? Duration { get; set; }

    [Column("Instructor_InstructorId")]
    public int InstructorId { get; set; }


    [ForeignKey("InstructorId")]  //links instructor idf to the instructor table
    public Instructor? Instructor { get; set; }
}