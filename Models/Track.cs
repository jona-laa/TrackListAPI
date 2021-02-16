using System.ComponentModel.DataAnnotations;

namespace TrackListAPI.Models
{
    public class Track
    {
        public int Id { get; set; }
        
        [Required]
        public string Artist { get; set; }
        
        [Required]
        public string Title { get; set; }
        
        [Required]
        public int Length { get; set; }
        
        [Required]
        public string Category { get; set; }
    }
}