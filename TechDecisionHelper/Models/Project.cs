using System.ComponentModel.DataAnnotations;

namespace ProjectDatabase.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }
        public string? Employer { get; set; }

        public string? Language { get; set; }
        public string? BackendFramework { get; set; }
        public string? Database { get; set; }
        public string? DataAbstractionLayer { get; set; }
        public string? CloudProvider { get; set; }
        public string? FrontendFramework { get; set; }
        public string? DevOpsTool { get; set; }
        public string? MobileFramework { get; set; }
        public string? UIFramework { get; set; }
        public string? FormFramework { get; set; }
    }
}
