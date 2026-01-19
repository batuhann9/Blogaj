using Blogaj.WebUI.DTOs.BlogCategoryDtos;
using Blogaj.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogaj.WebUI.DTOs.BlogCategoryDtos
{
    public class UpdateBlogCategoryDto
    {
        public int BlogCategoryId { get; set; }
        public string Name { get; set; } = default!;
        public List<ResultBlogCategoryDto> Blogs { get; set; }
    }
}
