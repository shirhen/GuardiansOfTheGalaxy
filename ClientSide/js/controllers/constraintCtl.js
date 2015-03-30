GuardiansApp.controller("constraintCtl", ['$scope',$http,userSerivce,constraintService, function($scope) {
  var usr = userSerivce.getUser();
  var contrSer = constraintService;
  $scope.addContr = function(contr){
  		contrSer.addContraint(contr);
  };
  $scope.getContrs = function(){
      contrSer.getContraints(usr);
  };
  $scope.editContr = function(contr){
      contrSer.editContraint(contr);
  };
  $scope.delContr = function(contr){
      contrSer.delContraint(contr);
  };

}]);