namespace TEACHER.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    public partial class AllField
    {
      
        [Key]
        public int Manv { get; set; }

        [Required]
        [StringLength(50)]
        public string TenNV { get; set; }

        [Required]
        [StringLength(20)]
        
        public string CMND { get; set; }

        public DateTime? Ngaycap { get; set; }

        [StringLength(50)]
        public string Tinhthanh { get; set; }

        public DateTime? Ngaysinh { get; set; }

        [StringLength(10)]
        public string Gioitinh { get; set; }

        [StringLength(10)]
        public string Nguyenquan { get; set; }

        [StringLength(50)]
        public string Dctamtru { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(15)]
        public string SDTrieng { get; set; }

        [StringLength(15)]
        public string SDTnha { get; set; }

        [StringLength(50)]
        public string Tinhtranghonnhan { get; set; }

        [StringLength(50)]
        public string Tinhtranglamviec { get; set; }

        public string Tentongiao { get; set; } = "";
        public string Tenchucvu { get; set; } = "";
        public string Tendantoc { get; set; } = "";
        public string Tenbangcap { get; set; } = "";
        public string TenDV { get; set; } = "";
        public string Tento { get; set; } = "";
        public string Tenngoaingu { get; set; } = "";
        public string Tentinhoc { get; set; } = "";
        public DateTime? Ngayvaolam { get; set; } = DateTime.Now;
        public int? Thamnien { get; set; } = 0;
    }
}
