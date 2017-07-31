import {signinService as s} from './service';
import * as ng from 'angular';

s.controller('signinController', ['$scope', 'adalAuthenticationService', function($scope, adalService){
  $scope.signin = function(){
    adalService.login();
  };
  $scope.signout = function(){
    adalService.logOut();
  };
}]);