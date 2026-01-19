namespace Blogaj.WebUI.DTOs.CourseCategoryDto
{
    public class CreateCourseCategoryDto
    {
        public string CategoryName { get; set; } = default!;
        public string Icon { get; set; } = default!;
        public string Description { get; set; } = default!;
        public bool Shown { get; set; }
        public List<ResultCourseCategoryDto> Courses { get; set;}

    }
}
