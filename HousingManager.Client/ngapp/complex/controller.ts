import {complexService as p} from './service';
import * as ng from 'angular';

class Entity {
  text: string;
  value: string;

  constructor(t: string, v: string) {
    this.text = t;
    this.value = v;
  }
}

class complex {
  name: string;
  lastName: string;

  constructor() {
    this.firstName = "N/A";
    this.lastName = "N/A";
  }
}

p.controller('complexController', ['$scope', '$mdDialog','complexFactory', function($scope, $mdDialog, complexFactory){
  $scope.perLoading = true;

  $scope.getPeople = function() {
    $scope.users = [];
    $scope.perLoading = true;
    complexFactory.getPeople($scope);
  };

  $scope.navigateTo = function(user, event) {
    $mdDialog.show(
      $mdDialog.alert()
        .title(user.firstName + ' ' + user.lastName)
        .textContent(user.guid)
        .ariaLabel('Test')
        .ok('Close')
        .openFrom('#user.guid')
        .closeTo('#user.guid')
        .targetEvent(event)
    );
  };

  $scope.createcomplexDialog = function(ev) {
    $mdDialog.show({
      controller: DialogController,
      templateUrl: 'ngapp/home/partials/createcomplexTemplate.html',
      parent: ng.element(document.body),
      targetEvent: ev,
      clickOutsideToClose:true
    })
    .then(function(complex) {
      complexFactory.postcomplex(complex);
      $scope.complexStatus = complex.firstName + " " + complex.lastName + ' has been added!';
    }, function() {
      $scope.complexStatus = 'Creating a complex was cancelled';
    });
  };

  function DialogController($scope, $mdDialog) {
    $scope.hide = function() {
      $mdDialog.hide();
    };

    $scope.cancel = function() {
      $mdDialog.cancel();
    };

    $scope.answer = function(answer) {
      $mdDialog.hide(answer);
    };
  };
}])