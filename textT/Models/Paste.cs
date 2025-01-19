using System.ComponentModel.DataAnnotations;

namespace textT.Models
{
    public class Paste
    {
        [Key]
        public int Id { get; set; }
        public string UniqueIdentifier { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
