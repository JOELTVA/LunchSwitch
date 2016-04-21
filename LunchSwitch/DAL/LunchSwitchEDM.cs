namespace LunchSwitch
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LunchSwitchEDM : DbContext
    {
        public LunchSwitchEDM()
            : base("name=LunchSwitchEDM")
        {
        }

        public virtual DbSet<lunchbox> Lunchboxes { get; set; }
        public virtual DbSet<meetup> Meetups { get; set; }
        public virtual DbSet<rating> Ratings { get; set; }
        public virtual DbSet<user> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<lunchbox>()
                .Property(e => e.content)
                .IsUnicode(false);

            modelBuilder.Entity<lunchbox>()
                .Property(e => e.foodCategory)
                .IsUnicode(false);

            modelBuilder.Entity<lunchbox>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<lunchbox>()
                .Property(e => e.picture)
                .IsUnicode(false);

            modelBuilder.Entity<lunchbox>()
                .Property(e => e.userId)
                .IsUnicode(false);

            modelBuilder.Entity<meetup>()
                .Property(e => e.information)
                .IsUnicode(false);

            modelBuilder.Entity<rating>()
                .Property(e => e.comment)
                .IsUnicode(false);

            modelBuilder.Entity<rating>()
                .Property(e => e.userId)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.userId)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.fullName)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.mobileNr)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .HasMany(e => e.meetups)
                .WithMany(e => e.users)
                .Map(m => m.ToTable("meetup_user", "lunchswitch").MapLeftKey("meetUpId").MapRightKey("userId"));
        }
    }
}
