namespace GuardiansOfTheGalaxy.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class shift_type
    {
        public shift_type()
        {
            shifts = new HashSet<shift>();
            shift_type_excemptions = new HashSet<shift_type_excemptions>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [StringLength(2000)]
        public string description { get; set; }

        [Required]
        [StringLength(15)]
        public string score { get; set; }

        public virtual ICollection<shift> shifts { get; set; }

        public virtual ICollection<shift_type_excemptions> shift_type_excemptions { get; set; }
    }
}
