import {complexService as c} from './service';
import * as ng from 'angular';

c.controller('complexController', ['$scope', '$mdDialog','complexFactory', function($scope, $mdDialog, complexFactory){
  $scope.aptLoading = true;
  $scope.complexes = [];
  $scope.units = [];

  $scope.getComplexes = function() {
    $scope.complexes = [];
    $scope.aptLoading = true;
    complexFactory.getComplexes($scope);
  };
  $scope.getUnits = function(complex) {
    $scope.complexName = complex.apartmentName;
    $scope.units = [];
    complex.aptUnitDTO.forEach(element => {
      //add capacity check
      $scope.units.push(element);
    });
  };

  $scope.navigateTo = function(unit, event) {
    $mdDialog.show(
      $mdDialog.alert()
        .title(unit.streetName)
        .textContent('Number of Beds Available: ' + unit.capacity)
        .ariaLabel('Test')
        .ok('Close')
        .openFrom('#item.guid')
        .closeTo('#item.guid')
        .targetEvent(event)
    );
  };
}])