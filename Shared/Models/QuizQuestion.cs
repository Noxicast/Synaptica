using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Synaptica.Shared.Models;

[Table("Questions")]
public class QuizQuestion
{
    [Key]
    [Column("questionId")]
    public int QuestionId { get; set; }

    [Column("question")]
    public string? Question { get; set; }

    [Column("answer")]
    public string? Answer { get; set; }

    [Column("quiz_quizId")]
    public int QuizId { get; set; }


    [ForeignKey("QuizId")]
    public Quiz? Quiz { get; set; }
}

