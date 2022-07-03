namespace TEACHER.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblNguoidung")]
    public partial class tblNguoidung
    {
        [Key]
        [StringLength(10)]
        public string Username { get; set; }

        [StringLength(20)]
        public string Pass { get; set; }

        [StringLength(20)]
        public string Chophepthaotac { get; set; }
    }
}
