namespace E_learning
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class brs_term
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
        public Guid brs_termId { get; set; }

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
        public string brs_name { get; set; }

        public string brs_Description { get; set; }

        [StringLength(1000)]
        public string brs_Synonyms { get; set; }

        [StringLength(1000)]
        public string brs_RelatedInformeaTerms { get; set; }

        public virtual IList<el_topic> Topics { get; set; }

        public virtual IList<brs_term> TermsBroader { get; set; }
        public virtual IList<brs_term> TermsNarrower { get; set; }
    }
}
