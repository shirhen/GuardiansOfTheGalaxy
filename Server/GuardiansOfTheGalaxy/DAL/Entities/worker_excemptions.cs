//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GuardiansOfTheGalaxy.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class worker_excemptions
    {
        public int id { get; set; }
        public int worker_id { get; set; }
        public int excemption_id { get; set; }
    
        public virtual excemption excemption { get; set; }
        public virtual worker worker { get; set; }
    }
}
