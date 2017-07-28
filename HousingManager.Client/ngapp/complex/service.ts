import { complexModule } from './module';

function failure (err) {
  console.log(err);
}

complexModule.factory('complexFactory', ['$http',function ($http){
  return {
    getComplexes: function ($scope) {
      $http.get('http://housingmanagerbusiness.azurewebsites.net/api/complex/').then(function (res) {
        res.data.forEach(element => {
          $scope.items.push(element);
        });
        $scope.perLoading = false;
      }, failure)
    }
  }
}]);

export{complexModule as complexService};