namespace Synaptica.Shared.Models;

public class User {
	public Guid? userId { get; set;}
	public string? username { get; set; }
	public string? email { get; set; }
	public string? password { get; set; }
}