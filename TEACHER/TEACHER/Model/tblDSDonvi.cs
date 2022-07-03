namespace TEACHER.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblDSDonvi")]
    public partial class tblDSDonvi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblDSDonvi()
        {
            Donvi_tolamviec_junction = new HashSet<Donvi_tolamviec_junction>();
        }

        [Key]
        [StringLength(10)]
        public string MaDV { get; set; }

        [StringLength(50)]
        public string TenDV { get; set; }

        [StringLength(50)]
        public string Ghichu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Donvi_tolamviec_junction> Donvi_tolamviec_junction { get; set; }
    }
}
