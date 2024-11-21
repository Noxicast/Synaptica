using System.ComponentModel.DataAnnotations;

namespace Synaptica.Shared.Models;

public class QuizQuestion
{
    [Key]
    public int questionId { get; set; }
    public string? question { get; set; }
    public string? answer { get; set; }
    public int quiz_quizId { get; set; }

    public Quiz? Quiz { get; set; }
}

