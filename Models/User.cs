using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Rest.Models;

public class User
{
    public int Id { get; set; }
    [MaxLength(1000)]
    public string? PlatformId { get; set; }
    // DataToUpdate
    [DefaultValue(1)]
    public int Level { get; set; }
    [DefaultValue(0)]
    public int BitcoinCount { get; set; }
    [DefaultValue(1)]
    public int DayNumber { get; set; }
    [DefaultValue(0)]
    public int Performance { get; set; }
}