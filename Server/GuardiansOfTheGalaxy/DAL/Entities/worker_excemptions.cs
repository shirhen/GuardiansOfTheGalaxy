namespace GuardiansOfTheGalaxy.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class worker_excemptions
    {
        public int id { get; set; }

        public int worker_id { get; set; }

        public int excemption_id { get; set; }

        public virtual excemption excemption { get; set; }

        public virtual worker worker { get; set; }
    }
}
