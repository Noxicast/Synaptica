namespace Synaptica.Shared.Models;

public class Notification {
	public Guid? notificationId { get; set;}
	public string? message { get; set; }
	public string? timeStamp { get; set; }
    public Guid? courseId { get; set; }
    
}