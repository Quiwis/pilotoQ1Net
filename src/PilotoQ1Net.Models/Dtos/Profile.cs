using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PilotoQ1Net.Models.Dtos
{
    public class Profile
    {
        [Required]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Type { get; set; }

        [Required]
        public List<Permision> Permisions { get; set; }

        [Required]
        public DateTime Updated { get; set; }
    }
}
