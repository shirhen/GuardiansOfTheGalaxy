GuardiansApp.service('userService', function($http) {
  var usr;
  var getUser = function() {
    //TODO: HOW?!?
    //usr = 
  };

  var isAdmin = function(){
      return usr.role == "admin";
  };

  return {
    getUser:getUser,
    isAdmin:isAdmin    
  };

});