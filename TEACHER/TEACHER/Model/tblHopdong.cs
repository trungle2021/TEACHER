namespace TEACHER.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblHopdong")]
    public partial class tblHopdong
    {
        [Key]
        [StringLength(10)]
        public string Mahopdong { get; set; }

        public int MaNV { get; set; }

        public DateTime? Ngaybatdau { get; set; }

        public DateTime? Ngayketthuc { get; set; }

        public int? Lanky { get; set; }

        public string Noidung { get; set; }

        public DateTime? Ngayky { get; set; }

        [StringLength(50)]
        public string Tennguoiky { get; set; }

        public string Ghichu { get; set; }

        public virtual tblNhanvien tblNhanvien { get; set; }
    }
}
