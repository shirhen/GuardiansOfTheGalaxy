GuardiansApp.controller("sideMenuCtl", ['$scope','menusService', 
	function($scope,MenusService) {
		$scope.btns = MenusService.getSideBtn();
		$scope.$watchCollection('btns', function() {
		});
	}	
]);