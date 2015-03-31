GuardiansApp.controller("constraintCtl", ['$scope','userService','constraintService', 
function($scope,userService,constraintService) {
  var usr = userService.getUser();
  var contrSer = constraintService;
  $scope.addContr = function(contr){
  		return contrSer.addContraint(contr);
  };
  $scope.getContrs = function(){
      return contrSer.getContraints(usr);
  };
  $scope.editContr = function(contr){
      return contrSer.editContraint(contr);
  };
  $scope.delContr = function(contr){
      return contrSer.delContraint(contr);
  };

}]);