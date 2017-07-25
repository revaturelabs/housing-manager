import { homeModule } from './module';

function failure (err) {
  console.log(err);
}

homeModule.factory('homeFactory', ['$http', function ($http) {
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
    postPerson: function (person) {
      $http({
        method: 'POST',
        url: 'http://housingmanagerbusiness.azurewebsites.net/api/Person/',
        withCredentials: true,
        headers: {
          'Access-Control-Allow-Origin': '*',
          'Content-Type': 'application/json',
          'Accept': 'application/json',
          'Access-Control-Allow-Credentials' : 'true',
          'Access-Control-Allow-Methods' : 'POST'
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

export{homeModule as homeService};