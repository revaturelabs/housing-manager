import * as ng from 'angular';
import 'angular-material';
import 'angular-route';

var ngApp = ng.module('ngApp',['ngRoute', 'ngMaterial']);

ngApp.config(['$routeProvider', function ($routeProvider) {
  $routeProvider
    .when('/', {
      controller: 'homeController',
      templateUrl: 'ts/home/template.html'
    })
    .otherwise({
      redirectTo: '/'
    });
}]);