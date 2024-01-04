using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Manament.DAL.Entities
{
    public partial class DBContext : DbContext
    {
        public DBContext()
            : base("name=DBContext")
        {
        }

        public virtual DbSet<CoffeCategory> CoffeCategories { get; set; }
        public virtual DbSet<CoffeDish> CoffeDishes { get; set; }
        public virtual DbSet<CoffeEmployer> CoffeEmployers { get; set; }
        public virtual DbSet<CoffeInvoice> CoffeInvoices { get; set; }
        public virtual DbSet<CoffeOrder> CoffeOrders { get; set; }
        public virtual DbSet<CoffeRole> CoffeRoles { get; set; }
        public virtual DbSet<CoffeTable> CoffeTables { get; set; }
        public virtual DbSet<LogBug> LogBugs { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoffeCategory>()
                .Property(e => e.CreateBy)
                .IsUnicode(false);

            modelBuilder.Entity<CoffeCategory>()
                .HasMany(e => e.CoffeDishes)
                .WithRequired(e => e.CoffeCategory)
                .HasForeignKey(e => e.CategoryID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CoffeDish>()
                .Property(e => e.DishesUrlImage)
                .IsUnicode(false);

            modelBuilder.Entity<CoffeDish>()
                .Property(e => e.CreateBy)
                .IsUnicode(false);

            modelBuilder.Entity<CoffeDish>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.CoffeDish)
                .HasForeignKey(e => e.DishesID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CoffeEmployer>()
                .Property(e => e.EUsername)
                .IsUnicode(false);

            modelBuilder.Entity<CoffeEmployer>()
                .Property(e => e.EPassword)
                .IsUnicode(false);

            modelBuilder.Entity<CoffeEmployer>()
                .Property(e => e.EUrlImage)
                .IsUnicode(false);

            modelBuilder.Entity<CoffeEmployer>()
                .Property(e => e.CreateBy)
                .IsUnicode(false);

            modelBuilder.Entity<CoffeEmployer>()
                .HasMany(e => e.CoffeInvoices)
                .WithRequired(e => e.CoffeEmployer)
                .HasForeignKey(e => e.EmoloyerID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CoffeInvoice>()
                .Property(e => e.CreateBy)
                .IsUnicode(false);

            modelBuilder.Entity<CoffeOrder>()
                .Property(e => e.CreateBy)
                .IsUnicode(false);

            modelBuilder.Entity<CoffeOrder>()
                .HasMany(e => e.CoffeInvoices)
                .WithRequired(e => e.CoffeOrder)
                .HasForeignKey(e => e.OrderID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CoffeOrder>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.CoffeOrder)
                .HasForeignKey(e => e.OrderID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CoffeRole>()
                .Property(e => e.CreateBy)
                .IsUnicode(false);

            modelBuilder.Entity<CoffeRole>()
                .HasMany(e => e.CoffeEmployers)
                .WithRequired(e => e.CoffeRole)
                .HasForeignKey(e => e.RoleID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CoffeTable>()
                .Property(e => e.TableUrlImage)
                .IsUnicode(false);

            modelBuilder.Entity<CoffeTable>()
                .Property(e => e.CreateBy)
                .IsUnicode(false);

            modelBuilder.Entity<CoffeTable>()
                .HasMany(e => e.CoffeOrders)
                .WithRequired(e => e.CoffeTable)
                .HasForeignKey(e => e.TableID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LogBug>()
                .Property(e => e.LogMessage)
                .IsUnicode(false);

            modelBuilder.Entity<LogBug>()
                .Property(e => e.CreateBy)
                .IsUnicode(false);

            modelBuilder.Entity<Menu>()
                .Property(e => e.MenuURL)
                .IsUnicode(false);

            modelBuilder.Entity<Menu>()
                .Property(e => e.CreateBy)
                .IsUnicode(false);

            modelBuilder.Entity<Menu>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.CreateBy)
                .IsUnicode(false);

            modelBuilder.Entity<Setting>()
                .Property(e => e.SetValue)
                .IsUnicode(false);

            modelBuilder.Entity<Setting>()
                .Property(e => e.CreateBy)
                .IsUnicode(false);

            modelBuilder.Entity<Setting>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);
        }
    }
}
