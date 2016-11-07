using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PilotoQ1Net.Models.Dtos
{
    public class Status
    {
        [Required]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Description { get; set; }

        [Required]
        [MaxLength(50)]
        public string Type { get; set; }


        [Required]
        public DateTime Updated { get; set; }
    }
}
