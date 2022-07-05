namespace TEACHER.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblBangcap")]
    public partial class tblBangcap
    {
       
        [Key]
        [StringLength(10)]
        public string Mabangcap { get; set; }

        [StringLength(50)]
        public string Tenbangcap { get; set; }

      
    }
}
