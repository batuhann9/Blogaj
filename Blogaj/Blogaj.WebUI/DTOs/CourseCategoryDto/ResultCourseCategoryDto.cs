using Blogaj.WebUI.DTOs.CourseDtos;

namespace Blogaj.WebUI.DTOs.CourseCategoryDto
{
    public class ResultCourseCategoryDto
    {
        public int CourseCategoryId { get; set; }
        public string CategoryName { get; set; } = default!;
        public string Icon { get; set; } = default!;
        public string Description { get; set; } = default!;
        public bool Shown { get; set; }
        public List<ResultCourseDto> Courses { get; set; }
    }
}
