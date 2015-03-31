GuardiansApp.controller("exemptionCtl", ['$scope','userService','exemptionService', 
function($scope,userService,exemptionService) {
  var usr = userService.getUser();
  var exempSer = exemptionService;
  $scope.addExemp = function(exemp){
  		return exempSer.addExemption(exemp);
  };
  $scope.getExemp = function(){
      return exempSer.getExemption(usr);
  };
  $scope.editExemp = function(exemp){
      return exempSer.editExemption(exemp);
  };
  $scope.delExemp = function(exemp){
      return exempSer.delExemption(exemp);
  };
  
}]);