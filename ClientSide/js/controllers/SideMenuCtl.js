GuardiansApp.controller("sideMenuCtl", ['$scope','menusService', 
	function($scope,MenusService) {
		$scope.btns = MenusService.sideBtn;
		$scope.tryb = "try";
		$scope.update = function(){
			$scope.$apply(function(){$scope.btns = MenusService.getSideBtn();});
		};
		 /*
		$scope.$watchCollection('btns', function() {
			if ($scope.btns)
				$scope.tryb = "XXX"+$scope.btns[0].name;
			else
				$scope.tryb = "XXXX";
		});*/
	}	
]);