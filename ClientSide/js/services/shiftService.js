GuardiansApp.service('shiftService', function($http) {

  var getShiftsByUser = function(user) {
    //$http
  };
  var getShiftsByDate= function(date) {
    //$http
  };
  var getAllShifts= function() {
    //$http
  };

  var approveBoard = function(isApproverd){//TODO:need to send something more?

  };

  var startAssign = function(){}; //TODO: what to send
  return {
    getAllShifts:getAllShifts,
    getShiftsByDate:getShiftsByDate,
    getShiftsByUser:getShiftsByUser,
    approveBoard:approveBoard,
    startAssign:startAssign
  };

});