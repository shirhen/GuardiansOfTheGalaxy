GuardiansApp.controller("MainMenuCtl", ['$scope', MenusService, function($scope) {
  $scope.constraintBtn = function(){
		MenusService.addBtn("הזן אילוץ", constraintCtl);
    MenusService.addBtn("צפה באילוצים", constraintCtl);
  };
  $scope.shiftBtn = function(){
    MenusService.addBtn("לוח תורנויות", constraintCtl);
  };
  $scope.ExemptionBtn = function(){
  	MenusService.addBtn("הזן פטור", constraintCtl);
    MenusService.addBtn("צפה בפטורים", constraintCtl);
  };
  $scope.AdminBtn = function(){
  	MenusService.addBtn("אשר אילוצים", constraintCtl);
    MenusService.addBtn("אשר פטורים", constraintCtl);
    MenusService.addBtn("הזן לוח", constraintCtl);
  };
}]);