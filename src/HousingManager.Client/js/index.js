var angular = require('angular');
var ngAddress = angular.module('ng-displayAddress', []);
var ngPeople = angular.module('ng-displayPeople', []);

ngAddress.controller('addressController', ['$scope', '$http', function($scope, $http) {
  $scope.getAddresses = function () {
    $http.get('http://localhost:52709/api/address').then(function (res) {
      $scope.addresses = res.data;

      count = 0;
      $scope.addresses.forEach(function(element) {
        element.counter = count++;
      });
    });
  };
}]);

ngPeople.controller('peopleController', ['$scope', '$http', function($scope, $http) {
  $scope.getPeople = function () {
    $http.get('http://localhost:52709/api/people').then(function (res) {
      $scope.people = res.data;

      count = 0;
      $scope.people.forEach(function(element) {
        element.counter = count++;
      })
    });
  };
}]);


