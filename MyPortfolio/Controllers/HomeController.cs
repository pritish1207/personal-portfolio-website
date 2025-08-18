// Controllers/HomeController.cs
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;
using System.Diagnostics;

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        
        private List<ProjectModel> GetProjects()
        {
            return new List<ProjectModel>
            {
                new ProjectModel
                {
                    Id = 1,
                    Title = "Artist Website",
                    Description = "A modern, immersive portfolio and music hub for Pritish S. It features a visually earthy tone with aesthetic overlays, bold branding, and smooth animations. Visitors can explore my biography, browse a full discography, and connect via social media.",
                    ImageUrl = "/images/projects/artist.png",
                    OfficialSiteUrl = "https://www.pritishs.com/", 
                    Technologies = new List<string> { "HTML5", "CSS3", "JavaScript", "UI/UX Design" }
                },
                new ProjectModel
                {
                    Id = 2,
                    Title = "Arcane Accounts - Gamified Budgeting App",
                    Description = "A game-like budgeting and finance tracking Android application. It incorporates features like achievements and levels to make budgeting more enjoyable. The app was developed using Kotlin and Firebase for the backend.",
                    ImageUrl = "/images/projects/arcane.png",
                    Technologies = new List<string> { "Kotlin", "Android Studio", "Firebase", "Mobile Development" }
                },
                new ProjectModel
                {
                    Id = 3,
                    Title = "ColourBounce WebGame",
                    Description = "A vibrant browser-based arcade game built with HTML5, CSS3, and JavaScript. Features real-time physics, responsive controls, dynamic ball movement, and increasing difficulty with animated obstacles. Fully custom design and code, optimized for desktop browsers.",
                    ImageUrl = "/images/projects/colourbounce.png",
                    GitHubUrl = "https://github.com/pritish1207/colour-bounce.git", 
                    Technologies = new List<string> { "HTML5", "CSS3", "JavaScript", "Game Logic" }
                },
                new ProjectModel
                {
                    Id = 4,
                    Title = "Interactive Web-Based Music Player",
                    Description = "A feature-rich music player with a custom playlist, album art, real-time waveform visualization with click-and-drag seeking, and controls for volume, tempo, and pitch. Built with modern front-end technologies.",
                    ImageUrl = "/images/projects/musicplayer.png",
                    GitHubUrl = "https://github.com/pritish1207/music-player-ui.git", 
                    Technologies = new List<string> { "HTML5", "CSS3", "JavaScript", "Audio Processing", "UI/UX" }
                },
                new ProjectModel
                {
                    Id = 5,
                    Title = "KineticGlass Cars - E-commerce Concept",
                    Description = "A fully responsive, single-page e-commerce experience built from scratch. Features a dynamic product catalogue rendered from a client-side data array, interactive filtering, details modals, and a stateful shopping cart. Implements a fluid 'glassmorphism' UI and GSAP animations.",
                    ImageUrl = "/images/projects/kinetic.png",
                    GitHubUrl = "https://github.com/pritish1207/kinetic-glass-cars-portfolio.git", 
                    Technologies = new List<string> { "JavaScript (ES6+)", "HTML5", "CSS3", "GSAP" }
                },
                new ProjectModel
                {
                    Id = 6,
                    Title = "Personal Portfolio Website (This Site)",
                    Description = "Designed and built this modern, product-showcase-inspired portfolio website using C# and ASP.NET Core MVC. The project emphasizes a strong visual and interactive user experience with features like animated text and dynamic skill-bar rendering. Structured with a data-driven backend for easy content management.",
                    ImageUrl = "/images/projects/portfolio.png",
                    Technologies = new List<string> { "C#", "ASP.NET Core MVC", ".NET 8", "Bootstrap" }
                },
                 new ProjectModel
                {
                    Id = 7,
                    Title = "Classic Central Radio App (In Development)",
                    Description = "A modern Android application for Classic Central Radio, featuring live streaming, integrated media controls, user authentication (email, Google, Facebook), and a dynamic light/dark theme. Currently in active development.",
                    ImageUrl = "/images/projects/ccr.jpg",
                    Technologies = new List<string> { "Kotlin", "Android Studio", "Firebase", "Live Streaming" }
                }
            };
        }

       
        private List<SkillModel> GetSkills()
        {
            return new List<SkillModel>
            {
                // Programming Languages
                new SkillModel { SkillName = "C#", Proficiency = 100, Category = "Programming Languages" },
                new SkillModel { SkillName = "Java", Proficiency = 90, Category = "Programming Languages" },
                new SkillModel { SkillName = "Kotlin", Proficiency = 85, Category = "Programming Languages" },
                new SkillModel { SkillName = "HTML5 & CSS3", Proficiency = 95, Category = "Programming Languages" },
                new SkillModel { SkillName = "JavaScript", Proficiency = 95, Category = "Programming Languages" },

                // Frameworks & Platforms
                new SkillModel { SkillName = "ASP.NET Core", Proficiency = 100, Category = "Frameworks & Platforms" },
                new SkillModel { SkillName = "Microsoft Azure", Proficiency = 75, Category = "Frameworks & Platforms" },
                new SkillModel { SkillName = "Android Studio", Proficiency = 85, Category = "Frameworks & Platforms" },

                // Databases
                new SkillModel { SkillName = "MySQL", Proficiency = 80, Category = "Databases" },
                new SkillModel { SkillName = "SQL Server", Proficiency = 85, Category = "Databases" },
                new SkillModel { SkillName = "Oracle", Proficiency = 70, Category = "Databases" },
                new SkillModel { SkillName = "Firebase", Proficiency = 80, Category = "Databases" },
                
                // Creative & Technical
                new SkillModel { SkillName = "Music Production (FL Studio)", Proficiency = 100, Category = "Creative & Technical" },
                new SkillModel { SkillName = "Video Editing", Proficiency = 100, Category = "Creative & Technical" },
                new SkillModel { SkillName = "Technical Writing", Proficiency = 90, Category = "Creative & Technical" },
                new SkillModel { SkillName = "Videography & Photography", Proficiency = 80, Category = "Creative & Technical" },
            };
        }

        

        public IActionResult Index() => View();
        public IActionResult About() => View();

        public IActionResult Skills()
        {
            var skills = GetSkills();
            var viewModel = skills.GroupBy(s => s.Category)
                                  .ToDictionary(g => g.Key, g => g.ToList());
            return View(viewModel);
        }

        public IActionResult Projects()
        {
            var projects = GetProjects();
            return View(projects);
        }

        [HttpGet]
        public IActionResult Contact() => View();

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}