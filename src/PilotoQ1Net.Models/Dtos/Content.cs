using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PilotoQ1Net.Models.Dtos
{
    public class Content
    {
        [Required]
        public int Id { get; set; }
        
        [MaxLength(50)]
        public string Tittle { get; set; }
        
        [MaxLength(400)]
        public string Description { get; set; }
        
        [MaxLength(4000)]
        public string Image { get; set; }
        
        [Required]
        public DateTime StartedDate { get; set; }
        
        [Required]
        public DateTime ExpiredDate { get; set; }
        
        [MaxLength(50)]
        public string TextAlign { get; set; }
        
        [Required]
        public bool Global { get; set; }
        
        [Required]
        public User createBy { get; set; }

        [Required]
        public Profile Profile { get; set; }
        
        public List<User> UserIds { get; set; }
        
        [Required]
        public DateTime Updated { get; set; }
    }
}
