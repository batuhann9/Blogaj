using Blogaj.DTO.DTOs.CourseCategoryDto;
using Blogaj.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogaj.DTO.DTOs.CourseDtos
{
    public class ResultCourseDto
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; } = default!;
        public string ImageUrl { get; set; } = default!;
        public int CategoryId { get; set; }
        public decimal Price { get; set; }
        public bool IsShown { get; set; }
        
        public ResultCourseCategoryDto CourseCategory { get; set; }
    }
}
