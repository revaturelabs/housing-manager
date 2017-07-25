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

  getPerson(id: number, res: any){
    this.firstName = res.data[id].firstName;
    this.lastName = res.data[id].lastName;
  }

  insertPerson(person) {
    this.firstName = person.firstName;
    this.lastName = person.lastName;
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

  getAddress(id: number, res: any){
    this.streetName = res.data[id].streetName;
    this.aptNum = res.data[id].aptNum;
    this.city = res.data[id].city;
    this.state = res.data[id].state;
    this.zipCode = res.data[id].zipCode;
  }
}

h.controller('homeController', ['$scope', '$mdDialog', 'homeFactory', function ($scope, $mdDialog, homeFactory) {
  $scope.myAddress = new Address();
  $scope.myPerson = new Person();
  $scope.entities = [
    new Entity('Address', 'Address'),
    new Entity('Person', 'Person'),
  ];

  $scope.processAddress = function (id) {
    homeFactory.getAddress(id, $scope.myAddress);
  }
  $scope.processPerson = function (id) {
    homeFactory.getPerson(id, $scope.myPerson);
  } 

  $scope.createPersonDialog = function(ev) {
    $mdDialog.show({
      controller: DialogController,
      templateUrl: 'ngapp/home/partials/createPersonTemplate.html',
      parent: ng.element(document.body),
      targetEvent: ev,
      clickOutsideToClose:true
    })
    .then(function(person) {
      $scope.status = person.firstName + " " + person.lastName + ' has been added!';
    }, function(error) {
      $scope.status = 'Creating a Person was cancelled: ' + error.message;
    });
  };

  function DialogController($scope, $mdDialog, homeFactory) {
    $scope.hide = function() {
      $mdDialog.hide();
    };

    $scope.cancel = function() {
      $mdDialog.cancel();
    };

    $scope.answer = function(answer) {
      $mdDialog.hide(answer);
    };

    $scope.insertPerson = function(person) {
      $mdDialog.hide(person);
      homeFactory.postPerson(person);
    }
  };
}]);