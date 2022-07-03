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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblTongiao()
        {
            tblNhanviens = new HashSet<tblNhanvien>();
        }

        [Key]
        [StringLength(10)]
        public string Matongiao { get; set; }

        [StringLength(50)]
        public string Tentongiao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblNhanvien> tblNhanviens { get; set; }
    }
}
