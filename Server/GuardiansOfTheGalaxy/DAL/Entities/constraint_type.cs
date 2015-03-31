namespace GuardiansOfTheGalaxy.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class constraint_type
    {
        public constraint_type()
        {
            constraints = new HashSet<constraint>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [StringLength(2000)]
        public string description { get; set; }

        public virtual ICollection<constraint> constraints { get; set; }
    }
}
