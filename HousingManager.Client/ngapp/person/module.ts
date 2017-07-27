import * as ng from "angular";
import 'file-loader?name=[name].[ext]&outputPath=ngapp/person/partials/!./partials/template.html';
import 'file-loader?name=[name].[ext]&outputPath=ngapp/person/partials/!./partials/createPersonTemplate.html';

var personModule = ng.module('ngPerson', []);

export { personModule };