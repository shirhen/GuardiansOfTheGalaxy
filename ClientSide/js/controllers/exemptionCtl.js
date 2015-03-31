GuardiansApp.controller("exemptionCtl", ['$scope','userService','exemptionService', 
function($scope,userService,exemptionService) {
  var usr = userService.getUser();
  var exempSer = exemptionService;
  $scope.addExemp = function(exemp){
  		return exempSer.addExemption(exemp);
  };
  var getUsrExemp = function(){
      return [{"name":"פטור זקן","startDate": "12/2/15", "endDate": "12/5/15","isApproved":"true"}];
      //return exempSer.getExemption(usr);
  };
  $scope.getExemp = function(){
      $scope.exempList = getUsrExemp();
  };
  $scope.editExemp = function(exemp){
      return exempSer.editExemption(exemp);
  };
  $scope.delExemp = function(exemp){
      return exempSer.delExemption(exemp);
  };
    $scope.exempList = getUsrExemp();
  
}]);