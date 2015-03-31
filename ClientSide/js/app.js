var GuardiansApp = angular.module("GuardiansApp",['ngRoute'])
.config(function($routeProvider, $locationProvider) {
  $routeProvider
   .when('/shift', {
    templateUrl: '/views/shift-partial.html',
    controller: 'shiftCtl'
  })
  .when('/constraints', {
    templateUrl: '/views/constraint-partial.html',
    controller: 'constraintCtl'
  }).when('/exemptions', {
    templateUrl: '/views/exemption-partial.html',
    controller: 'exemptionCtl'
  }).
      otherwise({
        redirectTo: '/shift'
      });

  // configure html5 to get links working on jsfiddle
$locationProvider.html5Mode({
  enabled: true,
  requireBase: false
});
});
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
/*
GuardiansApp.config(['$locationProvider',function($locationProvider) {
//$locationProvider.html5Mode({
  //enabled: true,
 // requireBase: false
//}).hashPrefix('#');
$locationProvider.html5Mode(true).hashPrefix('!');
  
}]);*/

/*
GuardiansApp.config(['$routeProvider','$locationProvider',
  function($routeProvider,$locationProvider) {
    $locationProvider.html5Mode({'enable':true,'requireBase':false}).hashPrefix('!');
    $routeProvider.
      when('/shift', {
        templateUrl: 'views/shift-partial.html',
        controller: 'shiftCtl'
      }).
      when('/constraints', {
        templateUrl: 'views/constraint-partial.html',
        controller: 'constraintCtl'
      }).
      when('/exemptions', {
        templateUrl: 'views/exemption-partial.html',
        controller: 'exemptionCtl'
      }).
      when('/admin', {
        //templateUrl: 'admin.html',
        //controller: 'adminCtl'
        redirectTo: '/admin/shift'
      }).
      when('/admin/shift', {
        templateUrl: 'views/admin-shift-partial.html',
        controller: 'adminCtl'
      }).
      when('/admin/constraints', {
        templateUrl: 'views/admin-constraint-partial.html',
        controller: 'adminCtl'
      }).
      when('/admin/exemptions', {
        templateUrl: 'views/admin-exemption-partial.html',
        controller: 'adminCtl'
      }).
      otherwise({
        redirectTo: '/shift'
      });
  }]);*/

