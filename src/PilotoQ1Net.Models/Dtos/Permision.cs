using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PilotoQ1Net.Models.Dtos
{
    public class Permision
    {
        [Required]
        public int Id { get; set; }
        
        [MaxLength(50)]
        public string Name { get; set; }
        
        [Required]
        public DateTime Updated { get; set; }
    }
}
