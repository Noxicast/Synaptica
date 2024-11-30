using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Synaptica.Shared.Models;

[Table("Enrollments")]
public class Enrollment {
	[Key]
	[Column("enrollmentId")]
	public int EnrollmentId { get; set;}

    [Column("enrollmentDate")]
    public string? EnrollmentDate { get; set; }

    [Column("progress")]
    public string? Progress { get; set; }

    [Column("user_userId")]
    public int? UserId { get; set; }

    [Column("course_courseId")]
    public int? CourseId { get; set; }


    [ForeignKey("UserId")]
    public User? User { get; set; }

    [ForeignKey("CourseId")]
    public Course? Course { get; set; }
}