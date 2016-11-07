using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PilotoQ1Net.Models.Dtos
{
    public class User
    {
        [Required]
        public int Id { get; set; }
        
        [MaxLength(50)]
        public string EmployeeCode { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Password { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }

        [Required]
        public DateTime Birthday { get; set; }

        [Required]
        [MaxLength(100)]
        public string Image { get; set; }

        [Required]
        public DateTime StartCompanyDate { get; set; }

        [Required]
        public bool StatusUser { get; set; }

        [Required]
        public Job JobId { get; set; }
        
        [Required]
        public List<Profile> Profiles { get; set; }
        
        [Required]
        public OrganizationalUnit OrganizationalUnitId { get; set; }

        [Required]
        public DateTime Updated { get; set; }
    }
}