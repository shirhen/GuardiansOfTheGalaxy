namespace GuardiansOfTheGalaxy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("shift")]
    public partial class shift
    {
        public int id { get; set; }

        [Column(TypeName = "date")]
        public DateTime date { get; set; }

        public int shift_type_id { get; set; }

        public int worker_id { get; set; }

        public int confirmed { get; set; }

        public virtual shift_type shift_type { get; set; }

        public virtual worker worker { get; set; }
    }
}
