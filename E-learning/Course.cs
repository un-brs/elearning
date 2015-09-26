using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Elearning
{
    [Table("el_course")]
    public partial class Course
    {
        [StringLength(200)]
        public string CreatedByName { get; set; }

        [StringLength(200)]
        public string CreatedByYomiName { get; set; }

        [StringLength(200)]
        public string CreatedOnBehalfByName { get; set; }

        [StringLength(200)]
        public string CreatedOnBehalfByYomiName { get; set; }

        [StringLength(200)]
        public string ModifiedByName { get; set; }

        [StringLength(200)]
        public string ModifiedByYomiName { get; set; }

        [StringLength(200)]
        public string ModifiedOnBehalfByName { get; set; }

        [StringLength(200)]
        public string ModifiedOnBehalfByYomiName { get; set; }


        public Guid OwnerId { get; set; }

        [StringLength(160)]
        public string OwnerIdName { get; set; }

        [StringLength(160)]
        public string OwnerIdYomiName { get; set; }

        public int OwnerIdDsc { get; set; }

        public int? OwnerIdType { get; set; }

        public Guid? OwningUser { get; set; }

        public Guid? OwningTeam { get; set; }

        [Key]
        [Column("el_courseId")]
        public Guid CourseId { get; set; }

        public DateTime? CreatedOn { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? ModifiedBy { get; set; }

        public Guid? CreatedOnBehalfBy { get; set; }

        public Guid? ModifiedOnBehalfBy { get; set; }

        public Guid? OwningBusinessUnit { get; set; }

        public int statecode { get; set; }

        public int? statuscode { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VersionNumber { get; set; }

        public int? ImportSequenceNumber { get; set; }

        public DateTime? OverriddenCreatedOn { get; set; }

        public int? TimeZoneRuleVersionNumber { get; set; }

        public int? UTCConversionTimeZoneCode { get; set; }

        [StringLength(512)]
        [Column("el_titleen")]
        public string TitleEn { get; set; }

        [Column("el_descriptionen")]
        public string DescriptionEn { get; set; }

        [StringLength(100)]
        [Column("el_urlen")]
        public string UrlEn { get; set; }

        [StringLength(512)]
        [Column("el_image")]
        public string Image { get; set; }

        [Column("el_order")]
        public decimal? Order { get; set; }

        public virtual IList<Topic> Topics { get; set; }
    }
}