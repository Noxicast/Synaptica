using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Synaptica.Shared.Models;

[Table("notification")]
public class Notification {
	[Key]
	[Column("notificationId")]
	public int NotificationId { get; set;}

    [Column("message")]
    public string? Message { get; set; }

    [Column("timestamp")]
    public string? Timestamp { get; set; }

    [Column("isRead")]
    public bool IsRead { get; set; }
   
    [Column("course_courseId")]
    public int CourseId { get; set;} 

    [Column("course_instructor_instructorId")]
    public int InstructorId { get; set; }

    [Column("user_userId")]
    public int UserId { get; set; }

    [ForeignKey("CourseId")]
    public Course? Course { get; set; }

    [ForeignKey("InstructorId")]
    public Instructor? Instructor { get; set; }

    [ForeignKey("UserId")]
    public User? User { get; set; }
}