using Blogaj.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogaj.DTO.DTOs.CourseCategoryDto
{
    public class CreateCourseCategoryDto
    {
        public string CategoryName { get; set; } = default!;
        public string Icon { get; set; } = default!;
        public string Description { get; set; } = default!;
        public bool Shown { get; set; }

    }
}
