GuardiansApp.controller("mainMenuCtl", ['$scope','$window', 'menusService','userService', 
function($scope,$window,MenusService,userService) {
  
  $scope.constraintBtn = function(){
		MenusService.addSideBtn("הזן אילוץ");
    MenusService.addSideBtn("צפה באילוצים");
    $window.location.href = '/constraints';
  };
  $scope.shiftBtn = function(){
    MenusService.addSideBtn("לוח תורנויות");
  };
  $scope.exemptionBtn = function(){
  	MenusService.addSideBtn("הזן פטור");
    MenusService.addSideBtn("צפה בפטורים");
  };

  $scope.getMainBtns = function(){
    MenusService.cleanMainBtns();
    MenusService.addMainBtn("תורנויות");
    MenusService.addMainBtn("אילוצים");
    MenusService.addMainBtn("פטורים");
    return MenusService.getMainBtns();
  };
  $scope.getAdminMainBtns = function(){
    MenusService.cleanMainBtns();
    MenusService.addMainBtn("תורנויות");
    MenusService.addMainBtn("אילוצים");
    MenusService.addMainBtn("פטורים");
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