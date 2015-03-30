GuardiansApp.controller("exemptionCtl", ['$scope',$http,userSerivce,exemptionService function($scope) {
  var usr = userSerivce.getUser();
  var exempSer = exemptionService;
  $scope.addExemp = function(exemp){
  		exempSer.addExemption(exemp);
  };
  $scope.getExemp = function(){
      exempSer.getExemption(usr);
  };
  $scope.editExemp = function(exemp){
      exempSer.editExemption(exemp);
  };
  $scope.delExemp = function(exemp){
      exempSer.delExemption(exemp);
  };
  
}]);