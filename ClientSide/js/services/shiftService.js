app.service('shiftService', function($http) {

  var getShiftsByUser = function(exemption) {
    //$http
  };
  var getShiftsByDate= function(exemption) {
    //$http
  };
  var getAllShifts= function(exemption) {
    //$http
  };

  return {
    addExemption:addExemption,
    getExemption:getExemptionsByUser,
    getAllExemption:getAllExemptions,
    editExemption:editExemption,
    delExemption:delExemption
  };

});