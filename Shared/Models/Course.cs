using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Synaptica.Shared.Models;

[Table("Courses")]
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

    [Column("instructor_instructorId")]
    public int? InstructorId { get; set; }

    [Column("completedPercentage")]
    public int CompletedPercentage { get; set; } = 0; //Default progress percent = 0%


    [ForeignKey("InstructorId")]  //links instructor idf to the instructor table
    public Instructor? Instructor { get; set; }
}