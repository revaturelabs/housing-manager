import {personService as p} from './service';
import * as ng from 'angular';

class Entity {
  text: string;
  value: string;

  constructor(t: string, v: string) {
    this.text = t;
    this.value = v;
  }
}

class Person {
  firstName: string;
  lastName: string;

  constructor() {
    this.firstName = "N/A";
    this.lastName = "N/A";
  }
}

p.controller('personController', ['$scope', '$mdDialog','personFactory', function($scope, $mdDialog, personFactory){
  $scope.perLoading = true;

  $scope.getPeople = function() {
    $scope.users = [];
    $scope.perLoading = true;
    personFactory.getPeople($scope);
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

  $scope.createPersonDialog = function(ev) {
    $mdDialog.show({
      controller: DialogController,
      templateUrl: 'ngapp/home/partials/createPersonTemplate.html',
      parent: ng.element(document.body),
      targetEvent: ev,
      clickOutsideToClose:true
    })
    .then(function(person) {
      personFactory.postPerson(person);
      $scope.personStatus = person.firstName + " " + person.lastName + ' has been added!';
    }, function() {
      $scope.personStatus = 'Creating a Person was cancelled';
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