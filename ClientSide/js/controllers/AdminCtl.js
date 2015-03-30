GuardiansApp.controller("adminCtl", ['$scope',$http,userSerivce, function($scope) {
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
  $scope.approveBoard = function(isApproverd){//TODO:need to send something more?

  };

  $scope.startAssign = function(){}; //TODO: what to send
  
}]);