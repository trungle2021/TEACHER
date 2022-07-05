namespace TEACHER.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblTongiao")]
    public partial class tblTongiao
    {
      

        [Key]
        [StringLength(10)]
        public string Matongiao { get; set; }

        [StringLength(50)]
        public string Tentongiao { get; set; }

    }
}
