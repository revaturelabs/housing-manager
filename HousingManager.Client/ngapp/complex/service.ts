import { complexModule } from './module';

function failure (err) {
  console.log(err);
}

complexModule.factory('complexFactory', ['$http',function ($http){
  return {
    getComplexes: function ($scope) {
      $http.get('http://housingmanagerbusiness.azurewebsites.net/api/ApartmentComplex/').then(function (res) {
        res.data.forEach(element => {
          $scope.complexes.push(element);
        });
        $scope.aptLoading = false;
      }, failure);
    }
  }
}]);

export{complexModule as complexService};