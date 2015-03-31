GuardiansApp.service('userService', function($http) {
  var usr = {};
  var getUser = function() {
    //TODO: HOW?!?
    //usr = {}; 
    usr.role = "soldier";
    usr.id="1234567";
  };

  var isAdmin = function(){
      return usr.role == "admin";
  };

  return {
    getUser:getUser,
    isAdmin:isAdmin    
  };

});