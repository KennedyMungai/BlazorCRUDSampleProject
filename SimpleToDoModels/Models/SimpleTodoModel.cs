using System.ComponentModel.DataAnnotations;

namespace SimpleToDoModels.Models;

public class SimpleToDoModels
{
    [Key]
    public int Id { get; set; }
    [Required]
    public DateTime DateAndTimeCreated { get; set; } = DateTime.Now;
    [Required]
    public string? Name { get; set; }
    [Required]
    public DateTime DeadLine { get; set; }
    public bool IsDone { get; set; } = false;
}