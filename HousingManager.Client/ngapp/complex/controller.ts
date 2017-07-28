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
  $scope.getUnits = function() {
    $scope.units = [];
    $scope.complex.aptUnitDTO.forEach(element => {
      //add capacity check
      $scope.units.push(element);
    });
  };

  $scope.navigateTo = function(complex, event) {
    $mdDialog.show(
      $mdDialog.alert()
        .title(complex.apartmentName)
        .textContent('Number of Units: ' + complex.aptUnitDTO.length)
        .ariaLabel('Test')
        .ok('Close')
        .openFrom('#item.guid')
        .closeTo('#item.guid')
        .targetEvent(event)
    );
  };
}])