using Blogaj.DTO.DTOs.BlogCategoryDtos;
using Blogaj.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogaj.DTO.DTOs.CategoryDtos
{
    public class BlogUpdateCategoryDto
    {
        public int BlogCategoryId { get; set; }
        public string Name { get; set; } = default!;
        public List<ResultBlogCategoryDto> Blogs { get; set; }
    }
}
