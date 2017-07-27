import { personModule } from './module';

function failure (err) {
  console.log(err);
}

personModule.factory('personFactory', ['$http',function ($http){
  return {
    getPeople: function ($scope) {
      $http.get('http://housingmanagerbusiness.azurewebsites.net/api/Person/').then(function (res) {
        res.data.forEach(element => {
          $scope.users.push(element);
        });
        $scope.perLoading = false;
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
        data: JSON.stringify(person)
        }).then(function(res){
          console.log(res);
        }, function(err){
          console.log(err);
        });
    }
  }
}]);

export{personModule as personService};