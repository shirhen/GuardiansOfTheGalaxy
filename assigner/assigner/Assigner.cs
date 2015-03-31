using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigner
{
    class Assigner
    {
        SortedList<int, Shift> shifts;
        SortedList<int, SortedList<SoldierID, Soldier>> potentialPerShift;
        SortedList<int, SortedList<SoldierID, Soldier>> assignment;
        SortedList<SoldierID, Soldier> potential;
        

        public bool canTakeShift( Soldier soldier, Shift shift ){ 
		    if(soldier.numberOfShifts + 1 > soldier.maxShifts){	// more than allowed amount of shifts
			    return false;
		    }

		    if(soldier.numberOfShifts + 1 > soldier.maxShifts){	// more than allowed amount of shifts
			    return false;
		    }

            //if(){	// in the same calendar week

            //}
		    return true;
	    }

        public bool assign (int shift, int soldierNum){
		    if( shift == shifts.Capacity ){
			    return true;
		    }

		    if( shifts[shift].allocations == 0 ){
                return assign(shift + 1, 0);
		    }

            if (soldierNum == potentialPerShift[shift].Capacity)
            {
                return false;
		    }

            Soldier temp = potentialPerShift.ElementAt(shift).Value.ElementAt(soldierNum).Value;
		    if( canTakeShift( temp , shifts[shift]) ){
			    assignment[shift].Add();
			    potentialPerShift[shift].allocations--;
			    if( findBoard(potentialPerShift, assignment, shift, soldier +1) )
				    return 1;
			    assignment[shift].remove(i.data());
			    potentialPerShift[shift].allocations++;
		    }
		    return findBoard(potentialPerShift,assignment, shift, soldier+1);
	    }

    }
}
