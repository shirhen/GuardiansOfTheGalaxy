using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigner
{
    public class SoldierIDComparer : IComparer<SoldierID>
    {
        public int Compare(SoldierID a, SoldierID b)
        {
            if (a.rank < b.rank)
                return -1;
            else if (a.rank > b.rank)
                return 1;
            else 
                return a.id - b.id;
        }
    }
    public class SoldierID
    {
        public int id, rank;
    }
    public class Soldier
    {
        public SoldierID id;
        public int totalShifts;
        public int numberOfShifts;
        public double shiftsScore;
        public int minShifts, maxShifts;
        public double minShiftsScore, maxShiftsScore;
        public SortedList<int, Ptor> ptors;
        public SortedList<int, ShiftException> exceptions;
        public SortedList<DateTime, Shift> previousShifts;
    }
}
