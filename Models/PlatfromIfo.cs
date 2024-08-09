using System.ComponentModel.DataAnnotations;

namespace Rest.Models;

public class UserPlatformInfo
{
    public int PlatformId { get; set; }
    
    [MaxLength(1000)]
    public string? Name { get; set; }
}
