import { home as h } from './module';

function failure (err) {
  console.log(err);
}

h.factory('homeFactory', ['$http', function ($http) {
  return {
    getAddress: function (id: number, obj) {
      $http.get('http://housingmanagerbusiness.azurewebsites.net/api/values/').then(function (res) {
        obj.getAddress(id, res);
      }, failure);
    },
  }
}]);