namespace Blogaj.Entity.Entities
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; } = default!;
        public string ImageUrl { get; set; }=default!;
        public int CategoryId { get; set; }
        public decimal Price { get; set; }
        public bool IsShown { get; set; }

        public CourseCategory CourseCategory { get; set; }
    }
}
