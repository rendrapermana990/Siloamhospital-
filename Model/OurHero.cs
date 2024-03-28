using System.Text.Json.Serialization;

namespace DotNet8API.Model
{
    public class OurHero
    {
        public int Id { get; set; } = 0;
        public required string FirstName { get; set; }
        public string LastName { get; set; } = string.Empty;
        public bool isActive { get; set; } = true;
    }
}
