namespace GuardiansOfTheGalaxy.DAL.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GuardsDB : DbContext
    {
        public GuardsDB()
            : base("name=Model1")
        {
        }

        public virtual DbSet<constraint_type> constraint_type { get; set; }
        public virtual DbSet<constraint> constraints { get; set; }
        public virtual DbSet<excemption> excemptions { get; set; }
        public virtual DbSet<rank> ranks { get; set; }
        public virtual DbSet<role> roles { get; set; }
        public virtual DbSet<shift> shifts { get; set; }
        public virtual DbSet<shift_type> shift_type { get; set; }
        public virtual DbSet<shift_type_excemptions> shift_type_excemptions { get; set; }
        public virtual DbSet<worker> workers { get; set; }
        public virtual DbSet<worker_excemptions> worker_excemptions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<constraint_type>()
                .HasMany(e => e.constraints)
                .WithRequired(e => e.constraint_type)
                .HasForeignKey(e => e.constraint_type_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<excemption>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<excemption>()
                .Property(e => e.description)
                .IsFixedLength();

            modelBuilder.Entity<excemption>()
                .HasMany(e => e.shift_type_excemptions)
                .WithRequired(e => e.excemption)
                .HasForeignKey(e => e.excemption_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<excemption>()
                .HasMany(e => e.worker_excemptions)
                .WithRequired(e => e.excemption)
                .HasForeignKey(e => e.excemption_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<rank>()
                .HasMany(e => e.workers)
                .WithRequired(e => e.rank)
                .HasForeignKey(e => e.rank_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<role>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<role>()
                .HasMany(e => e.workers)
                .WithRequired(e => e.role)
                .HasForeignKey(e => e.role_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<shift_type>()
                .HasMany(e => e.shifts)
                .WithRequired(e => e.shift_type)
                .HasForeignKey(e => e.shift_type_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<shift_type>()
                .HasMany(e => e.shift_type_excemptions)
                .WithRequired(e => e.shift_type)
                .HasForeignKey(e => e.shift_type_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<worker>()
                .HasMany(e => e.constraints)
                .WithOptional(e => e.worker)
                .HasForeignKey(e => e.worker_id);

            modelBuilder.Entity<worker>()
                .HasMany(e => e.shifts)
                .WithRequired(e => e.worker)
                .HasForeignKey(e => e.worker_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<worker>()
                .HasMany(e => e.worker_excemptions)
                .WithRequired(e => e.worker)
                .HasForeignKey(e => e.worker_id)
                .WillCascadeOnDelete(false);
        }
    }
}
