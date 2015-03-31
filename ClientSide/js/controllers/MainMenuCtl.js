GuardiansApp.controller("mainMenuCtl", ['$scope','$window', 'menusService','userService', '$location',
function($scope,$window,MenusService,userService,$location) {
  
  $scope.constraintBtn = function(){
    MenusService.clearSideBtn();
		MenusService.addSideBtn("הזן אילוץ");
    MenusService.addSideBtn("צפה באילוצים");
    //$location.path() == '/constraints';
    //$location.replace();
  };
  $scope.shiftBtn = function(){
    MenusService.clearSideBtn();
    MenusService.addSideBtn("לוח תורנויות");
    //$window.location.href = '/shift';
  };
  $scope.exemptionBtn = function(){
    MenusService.clearSideBtn();
  	MenusService.addSideBtn("הזן פטור");
    MenusService.addSideBtn("צפה בפטורים");
    //$window.location.href = '/exemptions';
  };

  $scope.getMainBtns = function(){
    MenusService.clearMainBtn();
    MenusService.addMainBtn("תורנויות");
    MenusService.addMainBtn("אילוצים");
    MenusService.addMainBtn("פטורים");
    return MenusService.getMainBtns();
  };
  $scope.getAdminMainBtns = function(){
    MenusService.clearMainBtn();
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