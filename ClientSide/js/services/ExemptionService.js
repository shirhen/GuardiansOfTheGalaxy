GuardiansApp.service('exemptionService', function($http) {

  var addExemption = function(exemption) {
    //$http
  };
  var getExemptionsByUser = function(user){
    $http.get('/someUrl').
  success(function(data, status, headers, config) {
    // this callback will be called asynchronously
    // when the response is available
    return data;
  }).
  error(function(data, status, headers, config) {
    // called asynchronously if an error occurs
    // or server returns response with an error status.
  });
  };
  var getAllExemptions = function(){

  };
  var editExemption = function(exemption){

  };
  var delExemption = function(exemption){

  };
  var approveExemption = function(isApproverd ,exemp){

  };
  return {
    addExemption:addExemption,
    getExemption:getExemptionsByUser,
    getAllExemption:getAllExemptions,
    editExemption:editExemption,
    delExemption:delExemption,
    approveExemp:approveExemption
  };

});