using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PilotoQ1Net.Models.Dtos
{
    public class Job
    {
        [Required]
        public int Id { get; set; }
        
        [MaxLength(50)]
        [Required]
        public string Tittle { get; set; }
        
        [Required]
        public DateTime Updated { get; set; }
    }
}
