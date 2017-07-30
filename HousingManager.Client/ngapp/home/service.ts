import { homeModule } from './module';

function failure (err) {
  console.log(err);
}

homeModule.factory('homeFactory', ['$http', function ($http) {
  return {
    getPeople: function ($scope) {
      $http.get('http://housingmanagerbusiness.azurewebsites.net/api/Person/').then(function (res) {
        res.data.forEach(element => {
          $scope.users.push(element);
        });
        $scope.perLoading = false;
      }, failure);
    },
    getComplexes: function ($scope) {
      $http.get('http://housingmanagerbusiness.azurewebsites.net/api/ApartmentComplex/').then(function (res) {
        res.data.forEach(element => {
          $scope.complexes.push(element);
        });
        $scope.aptLoading = false;
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
    },
    postAssignment: function (user, unit) {
      var guids = {Person: user.guid, ApartmentUnit: unit.guid};
      $http({
        method: 'POST',
        url: 'http://housingmanagerbusiness.azurewebsites.net/api/Person/assign/',
        withCredentials: true,
        headers: {
          'Access-Control-Allow-Origin': '*',
          'Content-Type': 'application/json',
          'Accept': 'application/json',
          'Access-Control-Allow-Credentials' : 'true',
          'Access-Control-Allow-Methods' : 'POST'
        },
        data: JSON.stringify(guids)
        }).then(function(res){
          console.log(res);
        }, function(err){
          console.log(err);
        });
    }
  }
}]);

export{homeModule as homeService};