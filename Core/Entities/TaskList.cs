namespace Core.Entities;

public class TaskList
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int CountConcluded { get { return Tasks?.Count(x => x.IsConcluded) ?? 0; } }
    public List<Tasks> Tasks { get; set; } = [];
}
