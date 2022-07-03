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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblTinhoc()
        {
            tblNhanviens = new HashSet<tblNhanvien>();
        }

        [Key]
        [StringLength(10)]
        public string Matinhoc { get; set; }

        [StringLength(50)]
        public string Tentinhoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblNhanvien> tblNhanviens { get; set; }
    }
}
