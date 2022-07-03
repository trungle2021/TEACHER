namespace TEACHER.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Donvi_tolamviec_junction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Donvi_tolamviec_junction()
        {
            tblNhanviens = new HashSet<tblNhanvien>();
        }

        public int Id { get; set; }

        [StringLength(10)]
        public string MaDV { get; set; }

        [StringLength(10)]
        public string Mato { get; set; }

        public virtual tblDSDonvi tblDSDonvi { get; set; }

        public virtual tblTolamviec tblTolamviec { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblNhanvien> tblNhanviens { get; set; }
    }
}
