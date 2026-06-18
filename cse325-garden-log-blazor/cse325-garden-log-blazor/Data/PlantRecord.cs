// Data/PlantRecord.cs
using System.ComponentModel.DataAnnotations;

namespace cse325_garden_log_blazor.Data;

public class PlantRecord
{
    public int Id { get; set; } // データベース用のID
    [Required]
    public string Name { get; set; } = string.Empty;
    public DateTime DatePlanted { get; set; } = DateTime.Now;
    public string Notes { get; set; } = string.Empty;
    public string? UserId { get; set; } // どのユーザーの記録か
}