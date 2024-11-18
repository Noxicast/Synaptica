namespace Synaptica.Shared.Models;

public class Course {
	public Guid? courseId { get; set;}
	public string? title { get; set; }
	public string? description { get; set; }
	public string? duration { get; set; }
	public Guid? instructorId { get; set; }
}