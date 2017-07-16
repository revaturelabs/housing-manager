var angular = require('angular');
var ngAddress = angular.module('ng-displayAddress', []);

ngAddress.controller('addressController', ['$scope', '$http', function($scope, $http) {
  $scope.getAddresses = function () {
    $http.get('http://localhost:52709/api/Address').then(function (res) {
      $scope.addresses = res.data;
      count = 0;
      $scope.addresses.forEach(function(element) {
        element.spot = count++;
      });
    });
  };

  $scope.addressCounter = 1;

  $scope.incrementAddressCounter = function () {
    $scope.addressCounter++;
  };
}]);