namespace TEACHER.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblTolamviec")]
    public partial class tblTolamviec
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblTolamviec()
        {
            Donvi_tolamviec_junction = new HashSet<Donvi_tolamviec_junction>();
        }

        [Key]
        [StringLength(10)]
        public string Mato { get; set; }

        [StringLength(50)]
        public string Tento { get; set; }

        public string Ghichu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Donvi_tolamviec_junction> Donvi_tolamviec_junction { get; set; }
    }
}
