namespace Elearning
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("brs_term")]
    public partial class Term
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
        [Column("brs_termId")]
        public Guid TermId { get; set; }

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

        [StringLength(100)]
        [Column("brs_name")]
        public string Name { get; set; }

        [Column("brs_Description")]
        public string Description { get; set; }

        [StringLength(1000)]
        [Column("brs_Synonyms")]
        public string Synonyms { get; set; }

        [StringLength(1000)]
        [Column("brs_RelatedInformeaTerms")]
        public string RelatedInformeaTerms { get; set; }

        public virtual IList<Topic> Topics { get; set; }

        public virtual IList<Term> TermsBroader { get; set; }
        public virtual IList<Term> TermsNarrower { get; set; }
    }
}
