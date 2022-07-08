namespace TEACHER.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblChucvu")]
    public partial class tblChucvu
    {
       
        [Key]
        [StringLength(10)]
        public string Machucvu { get; set; }

        [StringLength(50)]
        public string Tenchucvu { get; set; }

        public float? Hesochucvu { get; set; } = 0;

        public string Ghichu { get; set; } = "";

       
    }
}
