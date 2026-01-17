namespace Blogaj.Entity.Entities
{
    public class BlogCategory
    {
        public int BlogCategoryId { get; set; }
        public string Name { get; set; } = default!;
        public List<Blog> Blogs { get; set; }

    }
}
