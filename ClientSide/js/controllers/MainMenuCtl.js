GuardiansApp.controller("MainMenuCtl", ['$scope', MenusService, function($scope) {
  
  $scope.constraintBtn = function(){
		MenusService.addSideBtn("הזן אילוץ", constraintCtl);
    MenusService.addSideBtn("צפה באילוצים", constraintCtl);
  };
  $scope.shiftBtn = function(){
    MenusService.addSideBtn("לוח תורנויות", shiftCtl);
  };
  $scope.exemptionBtn = function(){
  	MenusService.addSideBtn("הזן פטור", exemptionCtl);
    MenusService.addSideBtn("צפה בפטורים", exemptionCtl);
  };

  $scope.getMainBtns = MenusService.getMainBtns();
  /*$scope.AdminconstraintBtn = function(){
  	MenusService.addSideBtn("אשר אילוצים", constraintCtl);
    MenusService.addSideBtn("אשר פטורים", constraintCtl);
    MenusService.addSideBtn("הזן לוח", constraintCtl);
  };*/
}]);