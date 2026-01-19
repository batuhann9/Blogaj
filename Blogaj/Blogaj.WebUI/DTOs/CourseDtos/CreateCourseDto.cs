namespace Blogaj.WebUI.DTOs.CourseDtos
{
    public class CreateCourseDto
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; } = default!;
        public string ImageUrl { get; set; } = default!;
        public int CourseCategoryId { get; set; }
        public decimal Price { get; set; }
        public bool IsShown { get; set; }

    }
}
