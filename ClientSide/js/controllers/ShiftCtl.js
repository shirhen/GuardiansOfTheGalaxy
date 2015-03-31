GuardiansApp.controller("shiftCtl", ['$scope','userService','shiftService',
	function($scope,userService,shiftService) {
	  	var usr = userService.getUser();
	  	
		$scope.getShiftsByUser = function(){
			return shiftService.getShiftsByUser(usr);
	  	};
		$scope.getShiftsByDate = function(date){
			return shiftService.getShiftsByDate(date);
		};
  		$scope.getAllShifts = function(){
	  		return shiftService.getAllShifts();
  	   	};
	}
]);