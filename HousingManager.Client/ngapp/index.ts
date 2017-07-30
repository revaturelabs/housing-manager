import * as ng from 'angular';
import './home/controller';
import './person/controller';
import './complex/controller';
import './signin/controller';
import 'angular-material';
import 'angular-route';

var ngApp = ng.module('ngApp',['ngRoute', 'ngMaterial', 'ngHome', 'ngPerson', 'ngComplex', 'ngSignin']);

ngApp.config(['$routeProvider', '$httpProvider', '$locationProvider', function ($routeProvider, $httpProvider, $locationProvider) {
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
    .when('/complex/', {
      controller: 'complexController',
      templateUrl: 'ngapp/complex/partials/template.html'
    })
    .otherwise({
      redirectTo: '/signin/'
    });

    $locationProvider.html5Mode(true).hashPrefix('!');
}]);