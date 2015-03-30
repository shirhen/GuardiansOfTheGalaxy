namespace GuardiansOfTheGalaxy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("excemption")]
    public partial class excemption
    {
        public excemption()
        {
            shift_type_excemptions = new HashSet<shift_type_excemptions>();
            worker_excemptions = new HashSet<worker_excemptions>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(10)]
        public string name { get; set; }

        [StringLength(10)]
        public string description { get; set; }

        [Column(TypeName = "date")]
        public DateTime start_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? end_date { get; set; }

        public virtual ICollection<shift_type_excemptions> shift_type_excemptions { get; set; }

        public virtual ICollection<worker_excemptions> worker_excemptions { get; set; }
    }
}
