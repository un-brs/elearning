namespace Elearning
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

        public virtual DbSet<Term> Terms { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Term>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<Course>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();

            modelBuilder.Entity<Course>()
                .Property(e => e.Order)
                .HasPrecision(23, 10);

            modelBuilder.Entity<Topic>()
                .Property(e => e.VersionNumber)
                .IsFixedLength();


            modelBuilder.Entity<Topic>()
                .HasMany(x => x.Courses)
                .WithMany(x => x.Topics)
                .Map(x =>
                {
                    x.ToTable("el_course_topic");
                    x.MapLeftKey("el_courseid");
                    x.MapRightKey("el_topicid");
                });

            modelBuilder.Entity<Topic>()
                .HasMany(x => x.Terms)
                .WithMany(x => x.Topics)
                .Map(x => {
                    x.ToTable("el_topic_term");
                    x.MapLeftKey("el_topicid");
                    x.MapRightKey("brs_termid");
                });

            modelBuilder.Entity<Term>()
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