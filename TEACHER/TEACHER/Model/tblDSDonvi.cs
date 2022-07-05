namespace TEACHER.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblDSDonvi")]
    public partial class tblDSDonvi
    {
       

        [Key]
        [StringLength(10)]
        public string MaDV { get; set; }

        [StringLength(50)]
        public string TenDV { get; set; }

        [StringLength(50)]
        public string Ghichu { get; set; }

       
    }
}
