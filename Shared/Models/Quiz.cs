using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Synaptica.Shared.Models;

[Table("quiz")]
public class Quiz {
	[Key]
	[Column("quizId")]
	public int QuizId { get; set;}

    [Column("passingScore")]
    public string? PassingScore { get; set; }

    [Column("duration")]
    public string? Duration { get; set; }

    [Column("course_courseId")]
    public int CourseId { get; set; }

    [ForeignKey("CourseId")]
    public Course? Course { get; set; }  
}