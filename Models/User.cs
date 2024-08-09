using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Rest.Models;

public class User: UserPlatformInfo
{
    public int Id { get; set; }
    
    // DataToUpdate
    [DefaultValue(1)]
    public int Level { get; set; }
    [DefaultValue(0)]
    public int BitcoinCount { get; set; }
    [DefaultValue(0)]
    public int Cache { get; set; }
    [DefaultValue(1)]
    public int DayNumber { get; set; }
    [DefaultValue(0)]
    public int Performance { get; set; }
}