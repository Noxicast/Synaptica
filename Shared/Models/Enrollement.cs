namespace Synaptica.Shared.Models;

public class Enrollement {
	public Guid? enrollementId { get; set;}
	public string? enrollementDate { get; set; }
	public string? progress { get; set; }
	public Guid? userId { get; set; }
    public Guid? courseId { get; set; }
}