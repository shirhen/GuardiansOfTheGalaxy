namespace GuardiansOfTheGalaxy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("rank")]
    public partial class rank
    {
        public rank()
        {
            workers = new HashSet<worker>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [Required]
        [StringLength(15)]
        public string score { get; set; }

        public virtual ICollection<worker> workers { get; set; }
    }
}
