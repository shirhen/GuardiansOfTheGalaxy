class ShiftType{
	int id;
	string description;
	string name;
	double score;
}
class Shift{
	ShiftType shiftType;
	int allocations;
	list<Ptor> ptorsPotrim;
	list<Soldier> potential;
	Date date;
	double getScore(){
		return shiftType.score;
	}
	void add(Soldier s){
		potential.add(s);
	}
	void remove(Soldier s){
		potential.remove(s);
	}
}

class Ptor{
	int id;
}

class shiftException{
	Date date;
	int exceptionType;
	string comment;
}

class Soldier{
	int id;
	int totalShifts;
	int numberOfShifts;
	double shiftsScore;
	int minShifts, maxShifts;
	int minShiftsScore, maxShiftsScore;
	list<Ptor> ptors;
	list<shiftException> exceptions;
}


class Board{
	list<Shift> shifts;
	list<Soldier> potential;
	DB db;
	void retrievePotential(){
		foreach row in db.getSoldiers{
			potential.add(row.getId(), row.getTotalShifts())
		}
	}
	int fillShiftsWithPotential(){
		for(Iterator<Shift> i = shifts.head ; i < shifts.tail ; i++){
			
		}
	}

	bool canTakeShift( Soldier soldier, Shift shift ){ 
		if(soldier.numberOfShifts + 1 > soldier.maxShifts){	// more than allowed amount of shifts
			return false;
		}

		if(soldier.shiftsScore + shift.getScore() > soldier.maxShiftsScore){	// score higher than max
			return false;
		}
		
		
		if(){	// in the same calendar week

		}

		return true;
	}


	bool findBoard ( list<list<Soldier>> potentialPerShift, list<list<Soldier>> assignment, int shift, int soldier){ 
		if( shift == board.length() ){
			return 1;
		}

		if( shifts[shift].allocations == 0 ){
			return findBoard(potentialPerShift, assignment, shift + 1, 0);
		}
		
		if( soldier == potentialPerShift ){
			return 0;
		}

		if( canTakeShift( potentialPerShift[shift][soldier], shift) ){
			assignment[shift].add(i.data());
			potentialPerShift[shift].allocations--;
			if( findBoard(potentialPerShift, assignment, shift, soldier +1) )
				return 1;
			assignment[shift].remove(i.data());
			potentialPerShift[shift].allocations++;
		}
		return findBoard(potentialPerShift,assignment, shift, soldier+1);
	}
}
