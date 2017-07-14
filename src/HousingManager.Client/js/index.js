var angular = require('angular');
var ngAddress = angular.module('ng-displayAddress', []);

ngAddress.controller('addressController', ['$scope', '$http', function($scope, $http) {
  $scope.getAddresses = function () {
    $http.get('http://localhost:52709/api/Address').then(function (res) {
      $scope.model = res.data;
    });
  };
}]);