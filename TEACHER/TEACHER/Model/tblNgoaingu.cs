namespace TEACHER.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblNgoaingu")]
    public partial class tblNgoaingu
    {
      

        [Key]
        [StringLength(10)]
        public string Mangoaingu { get; set; }

        [StringLength(50)]
        public string Tenngoaingu { get; set; }

       
    }
}
