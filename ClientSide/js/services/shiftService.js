GuardiansApp.service('shiftService', function($http) {

  var getShiftsByUser = function(exemption) {
    //$http
  };
  var getShiftsByDate= function(exemption) {
    //$http
  };
  var getAllShifts= function(exemption) {
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