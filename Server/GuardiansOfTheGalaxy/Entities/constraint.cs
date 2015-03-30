namespace GuardiansOfTheGalaxy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class constraint
    {
        public int id { get; set; }

        [Required]
        [StringLength(2000)]
        public string description { get; set; }

        public int permanent { get; set; }

        public int ranking { get; set; }

        [Column(TypeName = "date")]
        public DateTime start_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? end_date { get; set; }

        public int? worker_id { get; set; }

        public int constraint_type_id { get; set; }

        public virtual constraint_type constraint_type { get; set; }

        public virtual worker worker { get; set; }
    }
}
