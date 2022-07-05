namespace TEACHER.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblTolamviec")]
    public partial class tblTolamviec
    {
        

        [Key]
        [StringLength(10)]
        public string Mato { get; set; }

        [StringLength(50)]
        public string Tento { get; set; }

        public string Ghichu { get; set; }

       
    }
}
