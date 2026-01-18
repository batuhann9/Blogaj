using Blogaj.DTO.DTOs.BlogCategoryDtos;
using Blogaj.DTO.DTOs.BlogDtos;
using Blogaj.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogaj.DTO.DTOs.CategoryDtos
{
    public class BlogCreateCategoryDto
    {
        public string Name { get; set; } = default!;
        public List<ResultBlogCategoryDto> Blogs { get; set; }
    }
}
