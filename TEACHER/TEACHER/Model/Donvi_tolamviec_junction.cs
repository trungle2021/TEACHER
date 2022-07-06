namespace TEACHER.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Donvi_tolamviec_junction
    {
      
        public int Id { get; set; }

        [StringLength(10)]
        public string MaDV { get; set; }

        [StringLength(10)]
        public string Mato { get; set; }

        [StringLength(10)]
        public string TenTo { get; set; }

        [StringLength(10)]
        public string TenDV { get; set; }


    }
}
