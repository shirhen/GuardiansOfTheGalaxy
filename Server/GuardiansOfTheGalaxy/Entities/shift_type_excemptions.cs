namespace GuardiansOfTheGalaxy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class shift_type_excemptions
    {
        public int id { get; set; }

        public int shift_type_id { get; set; }

        public int excemption_id { get; set; }

        public virtual excemption excemption { get; set; }

        public virtual shift_type shift_type { get; set; }
    }
}
