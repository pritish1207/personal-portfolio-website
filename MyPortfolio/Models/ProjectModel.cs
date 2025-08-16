// Models/ProjectModel.cs
namespace MyPortfolio.Models
{
    public class ProjectModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string? GitHubUrl { get; set; }
        public string? LiveDemoUrl { get; set; }
        public string? OfficialSiteUrl { get; set; } 
        public List<string> Technologies { get; set; } = new List<string>();
    }
}