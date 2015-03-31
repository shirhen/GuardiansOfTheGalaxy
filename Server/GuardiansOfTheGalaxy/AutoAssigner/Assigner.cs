using GuardiansOfTheGalaxy.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardiansOfTheGalaxy
{
    class Assigner
    {
        SortedList<int, workShift> shifts;
        SortedList<int, SortedList<worker, worker>> potentialPerShift;
        SortedList<int, SortedList<worker, worker>> assignment;
        SortedList<worker, worker> potential;
        

        public bool canTakeShift(worker worker, workShift shift)
        {
            if (worker.numberOfShifts + 1 > worker.maxShifts)
            {	// more than allowed amount of shifts
			    return false;
		    }

            if (worker.numberOfShifts + 1 > worker.maxShifts)
            {	// more than allowed amount of shifts
			    return false;
		    }

            //if(){	// in the same calendar week

            //}

            //if() //not more than the percentage of ptors
            //{

            //}
		    return true;
	    }

        public bool canAttendShift(worker worker, workShift shift)
        {
            //if() // has ptor from this type of shifts
            //{
            //return false;
            //}

            //if() //has excemption
            //{
            //return false;
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

            worker temp = potentialPerShift.ElementAt(shift).Value.ElementAt(soldierNum).Value;
		    if( canTakeShift( temp , shifts[shift]) ){
                assignment.ElementAt(shift).Value.Add(temp, temp);
			    shifts[shift].allocations--;
                if (assign( shift, soldierNum + 1))
				    return true;
			    assignment.ElementAt(shift).Value.Remove(temp);
                shifts[shift].allocations++;
		    }
            return assign(shift, soldierNum + 1);
	    }
        
        public void getPotential()
        {
            foreach ( worker temp in PB.GuardiansDB.workers){
                temp.numberOfShifts=0;
                temp.maxShifts = 2;
                temp.scoreOfShifts = 0;
                temp.minNumShifts = 0; 
                temp.maxNumShifts = 2;
                temp.minScoreShifts = 0;
                temp.maxScoreShifts = 2;
                potential.Add(temp, temp);
            }
        }

        public void fillPotentialPerShift()
        {

        }
    }
}
