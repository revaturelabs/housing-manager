import {signinService as s} from './service';
import * as ng from 'angular';

s.controller('signinController', ['$scope', 'signinFactory', 'adalAuthenticationService', function($scope, signinFactory, adalService){
  $scope.signin = function(){
    adalService.login();
  };
  $scope.signout = function(){
    adalService.logout();
  };
}]);