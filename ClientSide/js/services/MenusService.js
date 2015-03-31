GuardiansApp.service('menusService', function() {
  var sideBtnList = [];
  var mainBtnList = [];
  var addSideBtn = function(name, btn,viewLink,controller) {
    var newObj;
    newObj.name = name;
    newObj.btn = btn;
    newObj.controller = controller;
    newObj.view = viewLink;
    sideBtnList.push(newObj);
  }

  var getSideBtn = function(){
      return sideBtnList;
  }

  var addMainBtn = function(name,btn) {
    var newObj;
    newObj.name = name;
    newObj.controller = controller;
    newObj.view = viewLink;
    mainBtnList.push(newObj);
  }

  var getMainBtn = function(){
      return mainBtnList;
  }
  return {
    addSideBtn: addSideBtn,
    getSideBtn: getSideBtn,
    addMainBtn: addMainBtn,
    getMainBtn: getMainBtn
  };

});