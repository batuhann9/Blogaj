namespace Blogaj.WebUI.DTOs.BlogCategoryDtos
{
    public class CreateBlogCategoryDto
    {
        public string Name { get; set; } = default!;
        public List<ResultBlogCategoryDto> Blogs { get; set; }
    }
}
