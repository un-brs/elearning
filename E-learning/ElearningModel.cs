namespace E_learning
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ElearningModel : DbContext
    {
        public ElearningModel()
            : base("name=Elearning")
        {
        }

        public virtual DbSet<brs_term> brs_term { get; set; }
        public virtual DbSet<el_course> el_course { get; set; }
        public virtual DbSet<el_topic> el_topic { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<brs_term>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<el_course>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<el_course>()
                .Property(e => e.el_order)
                .HasPrecision(23, 10);

            modelBuilder.Entity<el_topic>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();


            modelBuilder.Entity<el_topic>()
                .HasMany(x => x.Courses)
                .WithMany(x => x.Topics)
                .Map(x =>
                {
                    x.ToTable("el_course_topic");
                    x.MapLeftKey("el_courseid");
                    x.MapRightKey("el_topicid");
                });

            modelBuilder.Entity<el_topic>()
                .HasMany(x => x.Terms)
                .WithMany(x => x.Topics)
                .Map(x => {
                    x.ToTable("el_topic_term");
                    x.MapLeftKey("el_topicid");
                    x.MapRightKey("brs_termid");
                });

            modelBuilder.Entity<brs_term>()
                .HasMany(x => x.TermsNarrower)
                .WithMany(x => x.TermsBroader)
                .Map(x => {
                    x.ToTable("brs_brs_term_brs_term_narrower");
                    x.MapLeftKey("brs_termidOne");
                    x.MapRightKey("brs_termidTwo");
                });
        }
    }
}