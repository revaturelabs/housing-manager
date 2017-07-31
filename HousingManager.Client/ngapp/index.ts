import * as ng from 'angular';
import './home/controller';
import './person/controller';
import './complex/controller';
import './signin/controller';
import 'angular-material';
import 'angular-route';
import 'adal-angular/lib/adal-angular';

var ngApp = ng.module('ngApp',['ngRoute', 'ngMaterial', 'AdalAngular', 'ngHome', 'ngPerson', 'ngComplex', 'ngSignin']);

ngApp.config(['$routeProvider', '$httpProvider', '$locationProvider', 'adalAuthenticationServiceProvider', function ($routeProvider, $httpProvider, $locationProvider, adalProvider) {
  $routeProvider
    .when('/signin/', {
      controller: 'signinController',
      templateUrl: 'ngapp/signin/partials/template.html',
      requireADLogin: false
    })
    .when('/home/', {
      controller: 'homeController',
      templateUrl: 'ngapp/home/partials/template.html',
      requireADLogin: true
    })
    .when('/person/', {
      controller: 'personController',
      templateUrl: 'ngapp/person/partials/template.html',
      requireADLogin: true
    })
    .when('/complex/', {
      controller: 'complexController',
      templateUrl: 'ngapp/complex/partials/template.html',
      requireADLogin: true
    })
    .otherwise({
      redirectTo: '/signin/'
    });

    $locationProvider.html5Mode(true).hashPrefix('!');

    adalProvider.init({
      tenant: 'fredbelotterevature.onmicrosoft.com',
      clientId: '335ca58a-4c5f-404e-8a36-65aad238091b'
    }, $httpProvider);
}]);