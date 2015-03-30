var GardiansApp = angular.module("GardiansApp",[]);
GardiansApp.run('initialize', ['userService','MenusService', function(userService,MenusService){
	var usr = userService.getUser();
	if (usr.isAdmin)
	{
		MenusService.addMainBtn("תורנויות",shiftAdminBtn);
		MenusService.addMainBtn("אילוצים",constraintAdminBtn);
		MenusService.addMainBtn("פטורים",exemptionAdminBtn);
	} else {
		MenusService.addMainBtn("תורנויות",shiftBtn);
		MenusService.addMainBtn("אילוצים",exemptionBtn);
		MenusService.addMainBtn("פטורים",constraintBtn);
	}
}]);
