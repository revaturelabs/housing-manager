import {homeService as h} from './service';
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

class Address {
  streetName: string;
  aptNum: number;
  city: string;
  state: string;
  zipCode: number;

  constructor() {
    this.streetName = "N/A";
    this.aptNum = 0;
    this.city = "N/A";
    this.state = "N/A";
    this.zipCode = 0;
  }
}

h.controller('homeController', ['$scope', '$mdDialog', 'homeFactory', function ($scope, $mdDialog, homeFactory) {
  $scope.aptLoading = true;
  $scope.perLoading = true;
  $scope.users = [];
  $scope.complexes = [];
  $scope.units = [];

  $scope.getPeople = function() {
    $scope.users = [];
    $scope.perLoading = true;
    homeFactory.getPeople($scope);
  };
  $scope.getComplexes = function() {
    $scope.complexes = [];
    $scope.aptLoading = true;
    homeFactory.getComplexes($scope);
  };
  $scope.getUnits = function() {
    $scope.units = [];
    $scope.complex.aptUnitDTO.forEach(element => {
      //add capacity check
      $scope.units.push(element);
    });
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
      homeFactory.postPerson(person);
      $scope.personStatus = person.firstName + " " + person.lastName + ' has been added!';
    }, function() {
      $scope.personStatus = 'Creating a Person was cancelled';
    });
  };

  $scope.assignmentDialog = function(ev) {
    $mdDialog.show({
      controller: DialogController,
      templateUrl: 'ngapp/home/partials/assignmentTemplate.html',
      parent: ng.element(document.body),
      targetEvent: ev,
      clickOutsideToClose:true
    })
    .then(function() {
      homeFactory.postAssignment($scope.user, $scope.unit);
      $scope.assignmentStatus = $scope.user.firstName + " has been assigned to " + $scope.complex.apartmentName + " in Apartment #" + $scope.unit.addr.aptNum;
    }, function() {
      $scope.assignmentStatus = 'Assigning a Person to an Apartment was cancelled';
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
}]);