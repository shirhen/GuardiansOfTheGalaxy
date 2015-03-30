namespace GuardiansOfTheGalaxy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("worker")]
    public partial class worker
    {
        public worker()
        {
            constraints = new HashSet<constraint>();
            shifts = new HashSet<shift>();
            worker_excemptions = new HashSet<worker_excemptions>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(2000)]
        public string username { get; set; }

        public int phone { get; set; }

        public int rank_id { get; set; }

        public virtual ICollection<constraint> constraints { get; set; }

        public virtual rank rank { get; set; }

        public virtual ICollection<shift> shifts { get; set; }

        public virtual ICollection<worker_excemptions> worker_excemptions { get; set; }
    }
}
