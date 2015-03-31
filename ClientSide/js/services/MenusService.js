GuardiansApp.service('menusService', function() {
  var sideBtnList;
  var mainBtnList;

  var addSideBtn = function(name,viewLink,controller) {
    var newObj = {};
    newObj.name = name;
    newObj.controller = controller;
    newObj.link = viewLink;
    sideBtnList.push(newObj);
  }

  var getSideBtn = function(){
      return sideBtnList;
  }

  var clearSideBtn = function () {
      sideBtnList = [];
  }
  var clearMainBtn = function () {
      mainBtnList = [];
  }
  var addMainBtn = function(name,btn) {
    var newObj = {};
    newObj.name = name;
    newObj.controller = controller;
    newObj.link = viewLink;
    mainBtnList.push(newObj);
  }

  var getMainBtn = function(){
      return mainBtnList;
  }
  return {
    addSideBtn: addSideBtn,
    getSideBtn: getSideBtn,
    addMainBtn: addMainBtn,
    getMainBtn: getMainBtn,
    clearMainBtn:clearMainBtn,
    clearSideBtn:clearSideBtn,
    sideBtn:sideBtnList
  };

});