GuardiansApp.controller("SideMenuCtl", ['$scope','menusService', 
	function($scope,MenusService) {
		$scope.btns = MenusService.getSideBtns();
	}	
]);