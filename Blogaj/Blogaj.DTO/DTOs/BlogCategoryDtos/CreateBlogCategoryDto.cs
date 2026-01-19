using Blogaj.WebUI.DTOs.BlogCategoryDtos;
using Blogaj.WebUI.DTOs.BlogDtos;
using Blogaj.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogaj.WebUI.DTOs.BlogCategoryDtos
{
    public class CreateBlogCategoryDto
    {
        public string Name { get; set; } = default!;
        public List<ResultBlogCategoryDto> Blogs { get; set; }
    }
}
