GuardiansApp.controller("adminCtl", ['$scope','userService','constraintSerivce','exemptionSerivce','shiftSerivce',
function($scope,$http,userService,constraintSerivce,exemptionSerivce,shiftSerivce) {
  var usr = userService.getUser();
  $scope.getAllContr = function(){
  		//$http
  };
  $scope.getAllExemp = function(){

  };
  $scope.getAllShifts = function(){

  };
  $scope.approveExemp = function(isApproverd ,exemp){

  };
  $scope.approveContr = function(isApproverd ,contr){
  };
  $scope.approveBoard = function(isApproverd){

  };
  $scope.startAssign = function(){};  
}]);