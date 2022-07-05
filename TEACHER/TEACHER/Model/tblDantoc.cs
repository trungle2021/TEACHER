namespace TEACHER.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblDantoc")]
    public partial class tblDantoc
    {
       

        [Key]
        [StringLength(10)]
        public string Madantoc { get; set; }

        [StringLength(50)]
        public string Tendantoc { get; set; }

        
    }
}
