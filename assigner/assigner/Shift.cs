using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigner
{

    public class ShiftType
    {
        public int id;
        public string name;
        public string description;
        public double score;
    }

    public class Shift
    {
        public int id;
        public int allocations;
        public DateTime date;
        public ShiftType type;
        public int soldierId;
    }
}
