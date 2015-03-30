GuardiansApp.controller("mainMenuCtl", ['$scope','$location', 'menusService','userService', 
function($scope,$locationProvider,MenusService,userService) {
  
  $scope.constraintBtn = function(){
		MenusService.addSideBtn("הזן אילוץ", constraintCtl);
    MenusService.addSideBtn("צפה באילוצים", constraintCtl);
    $location.path('/constraint');
  };
  $scope.shiftBtn = function(){
    MenusService.addSideBtn("לוח תורנויות", shiftCtl);
  };
  $scope.exemptionBtn = function(){
  	MenusService.addSideBtn("הזן פטור", exemptionCtl);
    MenusService.addSideBtn("צפה בפטורים", exemptionCtl);
  };

  $scope.getMainBtns = function(){
    MenusService.cleanMainBtns();
    MenusService.addMainBtn("תורנויות",shiftBtn);
    MenusService.addMainBtn("אילוצים",exemptionBtn);
    MenusService.addMainBtn("פטורים",constraintBtn);
    return MenusService.getMainBtns();
  };
  $scope.getAdminMainBtns = function(){
    MenusService.cleanMainBtns();
    MenusService.addMainBtn("תורנויות",shiftBtn);
    MenusService.addMainBtn("אילוצים",exemptionBtn);
    MenusService.addMainBtn("פטורים",constraintBtn);
    return MenusService.getMainBtns();
  };//MenusService.getMainBtns();

  $scope.getIfAdmin = function(){
    return userService.isAdmin();
  };
  /*$scope.AdminconstraintBtn = function(){
  	MenusService.addSideBtn("אשר אילוצים", constraintCtl);
    MenusService.addSideBtn("אשר פטורים", constraintCtl);
    MenusService.addSideBtn("הזן לוח", constraintCtl);
  };*/
}]);