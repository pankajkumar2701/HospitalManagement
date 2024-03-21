using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace HospitalManagement.Entities
{
    /// <summary> 
    /// Represents a patient entity with essential details
    /// </summary>
    public class Patient
    {
        /// <summary>
        /// TenantId of the Patient 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the Patient 
        /// </summary>
        [Key]
        public Guid? PatientId { get; set; }
        /// <summary>
        /// Code of the Patient 
        /// </summary>
        public string? Code { get; set; }

        /// <summary>
        /// Required field Name of the Patient 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Foreign key referencing the Title to which the Patient belongs 
        /// </summary>
        public Guid? TitleId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Title
        /// </summary>
        [ForeignKey("TitleId")]
        public Title? Title { get; set; }

        /// <summary>
        /// Required field FirstName of the Patient 
        /// </summary>
        [Required]
        public string FirstName { get; set; }
        /// <summary>
        /// MiddleName of the Patient 
        /// </summary>
        public string? MiddleName { get; set; }
        /// <summary>
        /// LastName of the Patient 
        /// </summary>
        public string? LastName { get; set; }

        /// <summary>
        /// Foreign key referencing the Gender to which the Patient belongs 
        /// </summary>
        [Required]
        public Guid GenderId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Gender
        /// </summary>
        [ForeignKey("GenderId")]
        public Gender? Gender { get; set; }

        /// <summary>
        /// Required field Dob of the Patient 
        /// </summary>
        [Required]
        public DateTime Dob { get; set; }

        /// <summary>
        /// Required field Age of the Patient 
        /// </summary>
        [Required]
        public int Age { get; set; }
        /// <summary>
        /// DobIsApproximate of the Patient 
        /// </summary>
        public bool? DobIsApproximate { get; set; }
        /// <summary>
        /// NationalIdNumber of the Patient 
        /// </summary>
        public string? NationalIdNumber { get; set; }
        /// <summary>
        /// RegisteredOn of the Patient 
        /// </summary>
        public DateTime? RegisteredOn { get; set; }
        /// <summary>
        /// DateOfDeath of the Patient 
        /// </summary>
        public DateTime? DateOfDeath { get; set; }
        /// <summary>
        /// ReasonOfDeath of the Patient 
        /// </summary>
        public string? ReasonOfDeath { get; set; }
        /// <summary>
        /// IsDeceased of the Patient 
        /// </summary>
        public bool? IsDeceased { get; set; }
        /// <summary>
        /// ReferredBy of the Patient 
        /// </summary>
        public string? ReferredBy { get; set; }

        /// <summary>
        /// Required field Mobile of the Patient 
        /// </summary>
        [Required]
        public string Mobile { get; set; }
        /// <summary>
        /// Email of the Patient 
        /// </summary>
        public string? Email { get; set; }
        /// <summary>
        /// Foreign key referencing the Address to which the Patient belongs 
        /// </summary>
        public Guid? AddressId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Address
        /// </summary>
        [ForeignKey("AddressId")]
        public Address? Address { get; set; }
        /// <summary>
        /// LastVisitDate of the Patient 
        /// </summary>
        public DateTime? LastVisitDate { get; set; }
        /// <summary>
        /// EntityCode of the Patient 
        /// </summary>
        public string? EntityCode { get; set; }
        /// <summary>
        /// EntitySubTypeCode of the Patient 
        /// </summary>
        public string? EntitySubTypeCode { get; set; }
        /// <summary>
        /// BloodGroup of the Patient 
        /// </summary>
        public string? BloodGroup { get; set; }
        /// <summary>
        /// FileNumber of the Patient 
        /// </summary>
        public string? FileNumber { get; set; }
        /// <summary>
        /// CreatedBy of the Patient 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// Required field CreatedOn of the Patient 
        /// </summary>
        [Required]
        public DateTime CreatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Patient 
        /// </summary>
        public Guid? UpdatedBy { get; set; }
        /// <summary>
        /// UpdatedOn of the Patient 
        /// </summary>
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// AlternateMobile of the Patient 
        /// </summary>
        public string? AlternateMobile { get; set; }
        /// <summary>
        /// IsDisabled of the Patient 
        /// </summary>
        public bool? IsDisabled { get; set; }
        /// <summary>
        /// MobileNumberCountryCode of the Patient 
        /// </summary>
        public int? MobileNumberCountryCode { get; set; }
        /// <summary>
        /// AlternateNumberCountryCode of the Patient 
        /// </summary>
        public int? AlternateNumberCountryCode { get; set; }
        /// <summary>
        /// Foreign key referencing the Location to which the Patient belongs 
        /// </summary>
        public Guid? LocationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Location
        /// </summary>
        [ForeignKey("LocationId")]
        public Location? Location { get; set; }
        /// <summary>
        /// Import of the Patient 
        /// </summary>
        public bool? Import { get; set; }
        /// <summary>
        /// Foreign key referencing the Membership to which the Patient belongs 
        /// </summary>
        public Guid? MembershipId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Membership
        /// </summary>
        [ForeignKey("MembershipId")]
        public Membership? Membership { get; set; }
        /// <summary>
        /// PatientEnrollment of the Patient 
        /// </summary>
        public bool? PatientEnrollment { get; set; }
        /// <summary>
        /// EnrollmentDate of the Patient 
        /// </summary>
        public DateTime? EnrollmentDate { get; set; }
        /// <summary>
        /// Landline of the Patient 
        /// </summary>
        public string? Landline { get; set; }
        /// <summary>
        /// IsVip of the Patient 
        /// </summary>
        public bool? IsVip { get; set; }
        /// <summary>
        /// IsConfidential of the Patient 
        /// </summary>
        public bool? IsConfidential { get; set; }
    }
}