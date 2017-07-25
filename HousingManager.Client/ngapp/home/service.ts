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
    getPerson: function (id: number, obj) {
      $http.get('http://housingmanagerbusiness.azurewebsites.net/api/Person/').then(function (res) {
        obj.getPerson(id, res);
      }, failure);
    },
    insertPerson: function (person: any, obj) {
    //   return $http.post('http://housingmanagerbusiness.azurewebsites.net/api/Person/', JSON.stringify(person), {headers: {'Content-Type': 'application/json'}}).then(function(res){
    //     console.log("WE DID IT!")
    //   }, failure);
    // }
      $http({
        method: 'POST',
        url: 'http://housingmanagerbusiness.azurewebsites.net/api/Person/',
        withCredentials: true,
        headers: {
          'Access-Control-Allow-Origin': 'http://localhost',
          'Content-Type': 'application/json',
          'Access-Control-Allow-Credentials' : 'true',
          'Access-Control-Allow-Methods' : 'GET,PUT,POST,DELETE'
        },
        data: {person}
        }).then(function(res){
          console.log(res);
        }, function(err){
          console.log(err);
        });
    }
  }
}]);