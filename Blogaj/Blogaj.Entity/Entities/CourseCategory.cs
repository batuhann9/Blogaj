namespace Blogaj.Entity.Entities
{
    public class CourseCategory
    {
        public int CourseCategoryId { get; set; }
        public string CategoryName { get; set; } = default!;
        public string Icon { get; set; }= default!;
        public string Description { get; set; }=default!;
        public bool Shown { get; set; }


        public List<Course> Courses { get; set; }=new List<Course>();
    }
}
