using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigner
{
    class Assigner
    {
        SortedList<int, SortedList<SoldierID, Soldier>> potentialPerShift;
        SortedList<int, SortedList<SoldierID, Soldier>> assignment;
        SortedList<SoldierID, Soldier> potential;

        bool canTakeShift( Soldier soldier, Shift shift ){ 
		if(soldier.numberOfShifts + 1 > soldier.maxShifts){	// more than allowed amount of shifts
			return false;
		}

		if(soldier.numberOfShifts + 1 > soldier.maxShifts){	// more than allowed amount of shifts
			return false;
		}

		if(){	// in the same calendar week

		}
		return true;
	}

    }
}
