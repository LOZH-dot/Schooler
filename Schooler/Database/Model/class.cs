namespace Schooler.Database.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("class")]
    public partial class _class
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public _class()
        {
            schoolboy = new HashSet<schoolboy>();
            class_lesson = new HashSet<class_lesson>();
        }

        [Key]
        public long id_class { get; set; }

        [Required]
        [StringLength(10)]
        public string name_class { get; set; }

        [Required]
        [StringLength(50)]
        public string classroom_teacher { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<schoolboy> schoolboy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<class_lesson> class_lesson { get; set; }
    }
}
