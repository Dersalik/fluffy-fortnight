namespace BlazorApp.Models;

public class AboutMe
{
    public string Description { get; set; } = string.Empty;
    public List<string> Skills { get; set; } = new();
    public List<SkillCategory> SkillCategories { get; set; } = new();
    public string DetailOrQuote { get; set; } = string.Empty;
}

public class SkillCategory
{
    public string CategoryName { get; set; } = string.Empty;
    public string CategoryIcon { get; set; } = string.Empty;
    public string CategoryColor { get; set; } = string.Empty;
    public List<string> Skills { get; set; } = new();
}