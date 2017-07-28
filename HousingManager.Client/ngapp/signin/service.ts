import { signinModule } from './module';

function failure (err) {
  console.log(err);
}

signinModule.factory('signinFactory', ['$http',function ($http){
  return {

  }
}]);

export{signinModule as signinService};