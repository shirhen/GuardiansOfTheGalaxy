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
    
    public partial class shift_type
    {
        public shift_type()
        {
            this.shifts = new HashSet<shift>();
            this.shift_type_excemptions = new HashSet<shift_type_excemptions>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string score { get; set; }
    
        public virtual ICollection<shift> shifts { get; set; }
        public virtual ICollection<shift_type_excemptions> shift_type_excemptions { get; set; }
    }
}
