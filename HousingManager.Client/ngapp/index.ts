import * as ng from 'angular';
import './home/controller';
import 'angular-material';
import 'angular-route';

var ngApp = ng.module('ngApp',['ngRoute', 'ngMaterial', 'ngHome']);

ngApp.config(['$routeProvider', function ($routeProvider) {
  $routeProvider
    .when('/', {
      controller: 'homeController',
      templateUrl: 'ngapp/home/partials/template.html'
    })
    .otherwise({
      redirectTo: '/'
    });
}]);