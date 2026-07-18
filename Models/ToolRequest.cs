namespace webtool_tracker.Models;

public enum Priority { Low, Medium, High }

public enum Status { New, InProgress, Done, Rejected }

public class ToolRequest
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public string Department { get; set; } = "";
	public string Description { get; set; } = "";
	public Priority Priority { get; set; }
	public Status Status { get; set; }
	public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}