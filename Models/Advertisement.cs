namespace Api.Models;

public class Advertisement
{
    public int Id { get; set; }
    public string Title { get; set; } = String.Empty;
    public string Company { get; set; } = String.Empty;
    public string Description { get; set; } = String.Empty;
    public double OfferedSalary { get; set; }
    public DateOnly Deadline { get; set; }
    public DateOnly PostedDate { get; set; }
    public JobLevel JobLevel { get; set; }
}