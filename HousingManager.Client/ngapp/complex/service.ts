import { complexModule } from './module';

function failure (err) {
  console.log(err);
}

complexModule.factory('complexFactory', ['$http',function ($http){
  return {
    getPeople: function ($scope) {
      $http.get('http://housingmanagerbusiness.azurewebsites.net/api/complex/').then(function (res) {
        res.data.forEach(element => {
          $scope.users.push(element);
        });
        $scope.perLoading = false;
      }, failure);
    },
    postcomplex: function (complex) {
      $http({
        method: 'POST',
        url: 'http://housingmanagerbusiness.azurewebsites.net/api/complex/',
        withCredentials: true,
        headers: {
          'Access-Control-Allow-Origin': '*',
          'Content-Type': 'application/json',
          'Accept': 'application/json',
          'Access-Control-Allow-Credentials' : 'true',
          'Access-Control-Allow-Methods' : 'POST'
        },
        data: JSON.stringify(complex)
        }).then(function(res){
          console.log(res);
        }, function(err){
          console.log(err);
        });
    }
  }
}]);

export{complexModule as complexService};