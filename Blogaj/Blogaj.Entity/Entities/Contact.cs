using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogaj.Entity.Entities
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string MapUrl { get; set; } = default!;
        public string Adress { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Phone { get; set; } = default!;

    }
}
