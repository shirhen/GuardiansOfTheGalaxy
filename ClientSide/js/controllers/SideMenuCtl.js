GuardiansApp.controller("SideMenuCtl", ['$scope',MenusService, function($scope) {
  $scope.btns = MenusService.getBtns();
}]);