namespace Blogaj.WebUI.DTOs.BlogCategoryDtos
{
    public class UpdateBlogCategoryDto
    {
        public int BlogCategoryId { get; set; }
        public string Name { get; set; } = default!;
        public List<ResultBlogCategoryDto> Blogs { get; set; }
    }
}
