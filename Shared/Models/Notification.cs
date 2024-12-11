using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Synaptica.Shared.Models;

[Table("Notifications")]
public class Notification {
	[Key]
	[Column("notificationId")]
	public int NotificationId { get; set;}

    [Column("message")]
    public string? Message { get; set; }

    [Column("timestamp")]
    public string? Timestamp { get; set; }
   
    [Column("course_courseId")]
    public int CourseId { get; set;} 


    [ForeignKey("CourseId")]
    public Course? Course { get; set; }
}