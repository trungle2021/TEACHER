using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TEACHER.Model
{
    public partial class QLGV1 : DbContext
    {
        public QLGV1()
            : base("name=QLGV1")
        {
        }

        public virtual DbSet<Donvi_tolamviec_junction> Donvi_tolamviec_junction { get; set; }

        public virtual DbSet<tblBangcap> tblBangcaps { get; set; }
        public virtual DbSet<tblChucvu> tblChucvus { get; set; }
        public virtual DbSet<tblDantoc> tblDantocs { get; set; }
        public virtual DbSet<tblDSDonvi> tblDSDonvis { get; set; }
        public virtual DbSet<tblHopdong> tblHopdongs { get; set; }
        public virtual DbSet<tblNgoaingu> tblNgoaingus { get; set; }
        public virtual DbSet<tblNguoidung> tblNguoidungs { get; set; }
        public virtual DbSet<tblNhanvien> tblNhanviens { get; set; }
        public virtual DbSet<tblTinhoc> tblTinhocs { get; set; }
        public virtual DbSet<tblTolamviec> tblTolamviecs { get; set; }
        public virtual DbSet<tblTongiao> tblTongiaos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Donvi_tolamviec_junction>()
                .Property(e => e.MaDV)
                .IsUnicode(false);

            modelBuilder.Entity<Donvi_tolamviec_junction>()
                .Property(e => e.Mato)
                .IsUnicode(false);

            modelBuilder.Entity<Donvi_tolamviec_junction>()
                .HasMany(e => e.tblNhanviens)
                .WithOptional(e => e.Donvi_tolamviec_junction)
                .HasForeignKey(e => e.MaDV_To);

            modelBuilder.Entity<tblBangcap>()
                .Property(e => e.Mabangcap)
                .IsUnicode(false);

            modelBuilder.Entity<tblChucvu>()
                .Property(e => e.Machucvu)
                .IsUnicode(false);

            modelBuilder.Entity<tblDantoc>()
                .Property(e => e.Madantoc)
                .IsUnicode(false);

            modelBuilder.Entity<tblDSDonvi>()
                .Property(e => e.MaDV)
                .IsUnicode(false);

            modelBuilder.Entity<tblHopdong>()
                .Property(e => e.Mahopdong)
                .IsUnicode(false);

            modelBuilder.Entity<tblNgoaingu>()
                .Property(e => e.Mangoaingu)
                .IsUnicode(false);

            modelBuilder.Entity<tblNguoidung>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<tblNguoidung>()
                .Property(e => e.Pass)
                .IsUnicode(false);

            modelBuilder.Entity<tblNhanvien>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<tblNhanvien>()
                .Property(e => e.SDTrieng)
                .IsUnicode(false);

            modelBuilder.Entity<tblNhanvien>()
                .Property(e => e.SDTnha)
                .IsUnicode(false);

            modelBuilder.Entity<tblNhanvien>()
                .Property(e => e.Machucvu)
                .IsUnicode(false);

            modelBuilder.Entity<tblNhanvien>()
                .Property(e => e.Matinhoc)
                .IsUnicode(false);

            modelBuilder.Entity<tblNhanvien>()
                .Property(e => e.Mangoaingu)
                .IsUnicode(false);

            modelBuilder.Entity<tblNhanvien>()
                .Property(e => e.Mabangcap)
                .IsUnicode(false);

            modelBuilder.Entity<tblNhanvien>()
                .Property(e => e.SoBHXH)
                .IsUnicode(false);

            modelBuilder.Entity<tblNhanvien>()
                .Property(e => e.SoBHYT)
                .IsUnicode(false);

            modelBuilder.Entity<tblNhanvien>()
                .Property(e => e.Matongiao)
                .IsUnicode(false);

            modelBuilder.Entity<tblNhanvien>()
                .Property(e => e.Madantoc)
                .IsUnicode(false);

            modelBuilder.Entity<tblNhanvien>()
                .HasMany(e => e.tblHopdongs)
                .WithRequired(e => e.tblNhanvien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblTinhoc>()
                .Property(e => e.Matinhoc)
                .IsUnicode(false);

            modelBuilder.Entity<tblTolamviec>()
                .Property(e => e.Mato)
                .IsUnicode(false);

            modelBuilder.Entity<tblTongiao>()
                .Property(e => e.Matongiao)
                .IsUnicode(false);
        }
    }
}
