namespace webtool_tracker.Models;

public class StatusNote
{
    public int Id { get; set; }
	public int ToolRequestId { get; set; }
    public string Note { get; set; } = "";
	public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}