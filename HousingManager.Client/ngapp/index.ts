import * as ng from 'angular';
import './home/controller';
import './person/controller';
import './signin/controller';
import 'angular-material';
import 'angular-route';

var ngApp = ng.module('ngApp',['ngRoute', 'ngMaterial', 'ngHome', 'ngPerson', 'ngSignin']);

ngApp.config(['$routeProvider', '$locationProvider', '$httpProvider', function ($routeProvider, $locationProvider, $httpProvider) {
  $routeProvider
    .when('/signin/', {
      controller: 'signinController',
      templateUrl: 'ngapp/signin/partials/template.html'
    })
    .when('/home/', {
      controller: 'homeController',
      templateUrl: 'ngapp/home/partials/template.html'
    })
    .when('/person/', {
      controller: 'personController',
      templateUrl: 'ngapp/person/partials/template.html'
    })
    .otherwise({
      redirectTo: '/signin/'
    });

    $locationProvider.html5Mode(true).hashPrefix('!');
}]);