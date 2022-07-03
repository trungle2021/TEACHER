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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblBangcap()
        {
            tblNhanviens = new HashSet<tblNhanvien>();
        }

        [Key]
        [StringLength(10)]
        public string Mabangcap { get; set; }

        [StringLength(50)]
        public string Tenbangcap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblNhanvien> tblNhanviens { get; set; }
    }
}
