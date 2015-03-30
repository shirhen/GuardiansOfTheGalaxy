GuardiansApp.controller("exemptionCtl", ['$scope','userSerivce','exemptionService', 
function($scope,userSerivce,exemptionService) {
  var usr = userSerivce.getUser();
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