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
    insertPerson: function (person: string, obj) {
      //var p = obj.insertPerson(person);
      var test = { "FirstName": "Test", "LastName": "User" };
      return $http.post('http://housingmanagerbusiness.azurewebsites.net/api/Person/', test, {headers: {'Content-Type': 'application/json'}}).then(function(res){
        console.log("WE DID IT!")
      }, failure);
    }
  }
}]);