namespace Synaptica.Shared.Models;

public class QuizQuestion {
	public Guid? questionId { get; set;}
	public string? questionString { get; set; }
	public string? correctAnswer { get; set; }
	public Guid? quizId { get; set; }
}