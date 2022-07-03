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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblChucvu()
        {
            tblNhanviens = new HashSet<tblNhanvien>();
        }

        [Key]
        [StringLength(10)]
        public string Machucvu { get; set; }

        [StringLength(50)]
        public string Tenchucvu { get; set; }

        public float? Hesochucvu { get; set; }

        public string Ghichu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblNhanvien> tblNhanviens { get; set; }
    }
}
