namespace Blogaj.WebUI.DTOs.ContactDtos
{
    public class UpdateContactDto
    {
        public int ContactId { get; set; }
        public string MapUrl { get; set; } = default!;
        public string Adress { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Phone { get; set; } = default!;
    }
}
