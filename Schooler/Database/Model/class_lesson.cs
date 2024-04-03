namespace Schooler.Database.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class class_lesson
    {
        [Key]
        public long id_class_lesson { get; set; }

        public long id_class { get; set; }

        public long id_lesson { get; set; }

        public virtual _class _class { get; set; }

        public virtual lesson lesson { get; set; }
    }
}
