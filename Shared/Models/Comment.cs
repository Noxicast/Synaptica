namespace Synaptica.Shared.Models;

public class Comment {
	public Guid? commentId { get; set;}
	public string? content { get; set; }
	public string? timeStamp { get; set; }
	public Guid? courseId { get; set; }
    public Guid? userId { get; set; }
}