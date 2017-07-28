import {complexService as c} from './service';
import * as ng from 'angular';

class Entity {
  text: string;
  value: string;

  constructor(t: string, v: string) {
    this.text = t;
    this.value = v;
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

class ApartmentUnit {
    address: Address;
    capacity: number;

    constructor(){
        this.capacity = 0;
        this.address = new Address();
    }

}

class complex {
    apartmentName: string;
    address: Address;
    aptUnitDTO: number;

  constructor() {
    this.apartmentName = "N/A";
    this.address = new Address();
    this.aptUnitDTO = 0;
  }
}

c.controller('complexController', ['$scope', '$mdDialog','complexFactory', function($scope, $mdDialog, complexFactory){
  $scope.perLoading = true;

  $scope.getComplexes = function() {
    $scope.items = [];
    $scope.perLoading = true;
    complexFactory.getComplexes($scope);
  };

  $scope.navigateTo = function(item, event) {
    $mdDialog.show(
      $mdDialog.alert()
        .title(item.apartmentName)
        .textContent(item.guid)
        .ariaLabel('Test')
        .ok('Close')
        .openFrom('#item.guid')
        .closeTo('#item.guid')
        .targetEvent(event)
    );
  };

//   $scope.createcomplexDialog = function(ev) {
//     $mdDialog.show({
//       controller: DialogController,
//       templateUrl: 'ngapp/complex/partials/createcomplexTemplate.html',
//       parent: ng.element(document.body),
//       targetEvent: ev,
//       clickOutsideToClose:true
//     })
//     .then(function(complex) {
//       complexFactory.postcomplex(complex);
//       $scope.complexStatus = complex.firstName + " " + complex.lastName + ' has been added!';
//     }, function() {
//       $scope.complexStatus = 'Creating a complex was cancelled';
//     });
//   };

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