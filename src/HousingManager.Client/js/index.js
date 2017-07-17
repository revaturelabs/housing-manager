var angular = require('angular');
var ngHousingManager = angular.module('ng-housingManager', []);

ngHousingManager.controller('addressController', ['$scope', '$http', function($scope, $http) {
  $scope.getAddresses = function () {
    $http.get('http://localhost:52709/api/address').then(function (res) {
      $scope.addresses = res.data;

      var count = 1;
      $scope.addresses.forEach(function(element) {
        element.counter = count++;
      });
    });
  };
}]);

ngHousingManager.controller('peopleController', ['$scope', '$http', function($scope, $http) {
  $scope.getPeople = function () {
    $http.get('http://localhost:52709/api/person').then(function (res) {
      $scope.people = res.data;

      var count = 1;
      $scope.people.forEach(function(element) {
        element.counter = count++;
      });
    });
  };
}]);


