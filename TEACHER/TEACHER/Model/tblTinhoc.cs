namespace TEACHER.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblTinhoc")]
    public partial class tblTinhoc
    {
     

        [Key]
        [StringLength(10)]
        public string Matinhoc { get; set; }

        [StringLength(50)]
        public string Tentinhoc { get; set; }

       
    }
}
