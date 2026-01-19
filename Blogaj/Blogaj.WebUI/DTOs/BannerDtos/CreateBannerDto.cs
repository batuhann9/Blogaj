using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogaj.WebUI.DTOs.BannerDtos
{
    public class CreateBannerDto
    {
        public string Title { get; set; } = default!;
        public string ImageUrl { get; set; } = default!;
    }
}
