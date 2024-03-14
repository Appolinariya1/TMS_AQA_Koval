using System.Text.Json.Serialization;

namespace ValueOfObjects.Models;

public class User
{
    [JsonIgnore] public string? Fullname
    {
        get
        {
            return Firstname + " " + Lastname;
        }
    }

    [JsonPropertyName("firstname")] public string Firstname { get; set; }
    public string Lastname { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }
    
    
}