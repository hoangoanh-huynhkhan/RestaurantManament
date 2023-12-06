using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL.Entities
{
    public partial class DBContext : DbContext
    {
        public DBContext()
            : base("name=DBContext")
        {
        }

        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<Employer> Employers { get; set; }
        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<FoodType> FoodTypes { get; set; }
        public virtual DbSet<Oder> Oders { get; set; }
        public virtual DbSet<OderDetail> OderDetails { get; set; }
        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<TableLocal> TableLocals { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employer>()
                .Property(e => e.no__phone)
                .IsFixedLength();

            modelBuilder.Entity<Employer>()
                .HasMany(e => e.Bills)
                .WithRequired(e => e.Employer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Food>()
                .HasMany(e => e.OderDetails)
                .WithRequired(e => e.Food)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FoodType>()
                .HasMany(e => e.Foods)
                .WithRequired(e => e.FoodType)
                .HasForeignKey(e => e.food__type)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Oder>()
                .HasMany(e => e.Bills)
                .WithRequired(e => e.Oder)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Oder>()
                .HasMany(e => e.OderDetails)
                .WithRequired(e => e.Oder)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OderDetail>()
                .HasOptional(e => e.OderDetails1)
                .WithRequired(e => e.OderDetail1);

            modelBuilder.Entity<Table>()
                .HasMany(e => e.Bills)
                .WithRequired(e => e.Table)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TableLocal>()
                .HasMany(e => e.Tables)
                .WithRequired(e => e.TableLocal)
                .HasForeignKey(e => e.table__local)
                .WillCascadeOnDelete(false);
        }
    }
}
