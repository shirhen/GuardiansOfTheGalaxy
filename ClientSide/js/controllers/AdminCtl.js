GuardiansApp.controller("adminCtl", ['$scope','userSerivce','constraintSerivce','exemptionSerivce','shiftSerivce',
function($scope,$http,userSerivce,constraintSerivce,exemptionSerivce,shiftSerivce) {
  var usr = userSerivce.getUser();
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