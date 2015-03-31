namespace GuardiansOfTheGalaxy.DAL.Entities
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
        [StringLength(100)]
        public string name { get; set; }

        public int score { get; set; }

        public virtual ICollection<worker> workers { get; set; }
    }
}
