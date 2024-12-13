public class CourseProgress
{
    public string CourseName { get; set; } = string.Empty;
    public int CompletedPercentage { get; set; } // Completion in percentage
    public string Status => CompletedPercentage >= 100 ? "Completed" : "In Progress";
}
