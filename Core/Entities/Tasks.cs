namespace Core.Entities;

public class Tasks
{
    public int Id { get; set; }
    public int ListId { get; set; }
    public bool IsConcluded { get; set; } = false;
    public string Title { get; set; }
    public DateTime? DateConclusion { get; set; }
    public bool IsImportant { get; set; } = false;
}
