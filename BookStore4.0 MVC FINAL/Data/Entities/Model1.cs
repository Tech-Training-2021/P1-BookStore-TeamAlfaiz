using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Data.Entities
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=BookModel2")
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<bookDetail> bookDetails { get; set; }
        public virtual DbSet<cart> carts { get; set; }
        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<customer_Order_History> customer_Order_History { get; set; }
        public virtual DbSet<store> stores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>()
                .Property(e => e.admin_Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.admin_password)
                .IsUnicode(false);

            modelBuilder.Entity<bookDetail>()
                .Property(e => e.book_Name)
                .IsUnicode(false);

            modelBuilder.Entity<bookDetail>()
                .Property(e => e.book_Author)
                .IsUnicode(false);

            modelBuilder.Entity<category>()
                .Property(e => e.book_category)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.customer_Name)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.customer_Email)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.customer_Phone)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.customer_Address)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.customer_Password)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.customer_Gender)
                .IsUnicode(false);

            modelBuilder.Entity<store>()
                .Property(e => e.store_Name)
                .IsUnicode(false);

            modelBuilder.Entity<store>()
                .Property(e => e.store_Location)
                .IsUnicode(false);
        }
    }
}
