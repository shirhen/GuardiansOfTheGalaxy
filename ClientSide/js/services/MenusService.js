app.service('MenusService', function() {
  var btnList = [];

  var addBtn = function(name, viewLink,controller) {
    var newObj;
    newObj.name = name;
    newObj.controller = controller;
    newObj.view = viewLink;
    btnList.push(newObj);
  }

  var getBtn = function(){
      return btnList;
  }

  return {
    addBtn: addBtn,
    getBtn: getBtn
  };

});