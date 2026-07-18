using Microsoft.EntityFrameworkCore;
using webtool_tracker.Models;

namespace webtool_tracker.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<ToolRequest> ToolRequest => Set<ToolRequest>();
	public DbSet<StatusNote> StatusNote => Set<StatusNote>();
}