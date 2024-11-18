namespace Synaptica.Shared.Models;

public class Quiz {
	public Guid? quizId { get; set;}
	public string? passingScore { get; set; }
	public string? duration { get; set; }
	public Guid? courseId { get; set; }
}