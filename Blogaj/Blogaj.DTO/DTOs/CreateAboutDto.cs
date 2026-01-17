using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogaj.DTO.DTOs
{
    public class CreateAboutDto
    {   
        //public int AboutId { get; set; }
        public string Description { get; set; } = default!;
        public string ImageUrl { get; set; } = default!;
        public string ImageUrl1 { get; set; } = default!;
        public string ImageUrl2 { get; set; } = default!;
        public string ImageUrl3 { get; set; } = default!;
        public string Item1 { get; set; }
        public string Item2 { get; set; }
        public string Item3 { get; set; }
        public string Item4 { get; set; }
    }
}
