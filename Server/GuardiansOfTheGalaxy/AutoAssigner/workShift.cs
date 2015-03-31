using GuardiansOfTheGalaxy.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuardiansOfTheGalaxy
{
    public class workShift
    {
        public int id;
        public int allocations;
        public DateTime date;
        public shift_type type;
        public int soldierId;
    }
}