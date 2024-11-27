using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Synaptica.Shared.Models;

[Table("comment")]
public class Comment {
	[Key]
	[Column("commentId")]
	public int CommentId { get; set;}

    [Column("content")]
    public string? Content { get; set; }

    [Column("timestamp")]
    public string? TimeStamp { get; set; }

    [Column("course_courseId")]
    public int CourseId { get; set; }

    [Column("course_instructor_instructorId")]
    public int InstructorId { get; set; }

    [Column("user_userId")]
    public int UserId { get; set; }



    [ForeignKey("UserId")]
    public User? User { get; set; }

    [ForeignKey("CourseId")]
    public Course? Course { get; set; }

    [ForeignKey("InstructorId")]
    public Instructor? Instructor { get; set; }

}