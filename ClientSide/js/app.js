var GuardiansApp = angular.module("GuardiansApp",['ngRoute']);
/*
GuardiansApp.run(['userService','MenusService', function(userService,MenusService,$routeProvider,$locationProvider){
	var usr = userService.getUser();
	if (usr.isAdmin)
	{
		$location.path('/admin');
		
		MenusService.addMainBtn("תורנויות",shiftAdminBtn);
		MenusService.addMainBtn("אילוצים",constraintAdminBtn);
		MenusService.addMainBtn("פטורים",exemptionAdminBtn);
	} else {
		$location.path('/');
		//MenusService.addMainBtn("תורנויות",shiftBtn);
		//MenusService.addMainBtn("אילוצים",exemptionBtn);
		//MenusService.addMainBtn("פטורים",constraintBtn);
	}
}]);*/

GuardiansApp.config(['$routeProvider',
  function($routeProvider) {
    $routeProvider.
      when('/shift', {
        templateUrl: 'partials/shift-partial.html',
        controller: 'shiftCtl'
      }).
      when('/constraints', {
        templateUrl: 'partials/constraint-partial.html',
        controller: 'constraintCtl'
      }).
      when('/exemptions', {
        templateUrl: 'partials/exemption-partial.html',
        controller: 'exemptionCtl'
      }).
      when('/admin', {
        //templateUrl: 'admin.html',
        //controller: 'adminCtl'
        redirectTo: '/admin/shift'
      }).
      when('/admin/shift', {
        templateUrl: 'partials/admin-shift-partial.html',
        controller: 'adminCtl'
      }).
      when('/admin/constraints', {
        templateUrl: 'partials/admin-constraint-partial.html',
        controller: 'adminCtl'
      }).
      when('/admin/exemptions', {
        templateUrl: 'partials/admin-exemption-partial.html',
        controller: 'adminCtl'
      }).
      otherwise({
        redirectTo: '/shift'
      });
  }]);