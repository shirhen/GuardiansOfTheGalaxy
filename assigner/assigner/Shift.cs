using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigner
{

    public class ShiftType
    {
        int id;
        string name;
        string description;
        double score;
    }

    public class Shift
    {
        int id;
        DateTime date;
        ShiftType type;
        int soldierId;
    }
}
