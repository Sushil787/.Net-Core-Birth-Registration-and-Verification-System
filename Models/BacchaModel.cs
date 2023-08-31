using System;
using System.ComponentModel.DataAnnotations;

namespace AspnetIdentityRoleBasedTutorial.Models
{
    public class BacchaModel
    {
        public Guid? Id { get; set; }
        
        [Required(ErrorMessage = "Name is required.")]
        public string? Name { get; set; }

        public string? Image { get; set; }
        
        [Required(ErrorMessage = "Father's name is required.")]
        public string? FatherName { get; set; }
        
        [Required(ErrorMessage = "Mother's name is required.")]
        public string? MotherName { get; set; }
        
        public string? GrandFatherName { get; set; }
        public string? GrandMotherName { get; set; }
        
        [Required(ErrorMessage = "Home location is required.")]
        public string? HomeLocation { get; set; }
        
        public string? HospitalName { get; set; }
        public string? HospitaLocation { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public bool IsVerified { get; set; } = false;
    }
}
