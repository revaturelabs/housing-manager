import * as ng from 'angular';
import './home/controller';
import './person/controller';
import './complex/controller';
import 'angular-material';
import 'angular-route';

var ngApp = ng.module('ngApp',['ngRoute', 'ngMaterial', 'ngHome', 'ngPerson', 'ngComplex']);

ngApp.config(['$routeProvider', function ($routeProvider) {
  $routeProvider
    .when('/home', {
      controller: 'homeController',
      templateUrl: 'ngapp/home/partials/template.html'
    })
    .when('/person', {
      controller: 'personController',
      templateUrl: 'ngapp/person/partials/template.html'
    })
    .when('/complex', {
      controller: 'complexController',
      templateUrl: 'ngapp/complex/partials/template.html'
    })
    .otherwise({
      redirectTo: '/home'
    });
}]);