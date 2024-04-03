namespace Schooler.Database.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lesson")]
    public partial class lesson
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lesson()
        {
            attendance = new HashSet<attendance>();
            class_lesson = new HashSet<class_lesson>();
        }

        [Key]
        public long id_lesson { get; set; }

        [Required]
        [StringLength(100)]
        public string name_predmet { get; set; }

        [Required]
        [StringLength(100)]
        public string teacher { get; set; }

        [Required]
        [StringLength(30)]
        public string day { get; set; }

        public TimeSpan start_time { get; set; }

        public TimeSpan end_time { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<attendance> attendance { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<class_lesson> class_lesson { get; set; }
    }
}
