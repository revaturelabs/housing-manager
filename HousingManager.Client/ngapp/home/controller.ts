import { home as h } from './module';
import './service';

class Entity {
  text: string;
  value: string;

  constructor(t: string, v: string) {
    this.text = t;
    this.value = v;
  }
}

class Address {
  streetName: string;
  aptNum: number;
  city: string;
  state: string;
  zipCode: number;

  constructor() {
    this.streetName = "N/A";
    this.aptNum = 0;
    this.city = "N/A";
    this.state = "N/A";
    this.zipCode = 0;
  }

  getAddress(id, res: any){
    this.streetName = res.data[id].streetName;
    this.aptNum = res.data[id].aptNum;
    this.city = res.data[id].city;
    this.state = res.data[id].state;
    this.zipCode = res.data[id].zipCode;
  }
}

h.controller('homeController', ['$scope', 'homeFactory', function ($scope, homeFactory) {
  $scope.myAddress = new Address();
  $scope.entities = [
    new Entity('Address', 'Address'),
  ];

  $scope.processRequest = function (id) {
    homeFactory.getAddress(id, $scope.myAddress);
  }
}]);