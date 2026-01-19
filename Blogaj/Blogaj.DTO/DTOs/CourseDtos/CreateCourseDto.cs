using Blogaj.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogaj.WebUI.DTOs.CourseDtos
{
    public class CreateCourseDto
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; } = default!;
        public string ImageUrl { get; set; } = default!;
        public int CourseCategoryId { get; set; }
        public decimal Price { get; set; }
        public bool IsShown { get; set; }

    }
}
