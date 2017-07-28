import * as ng from "angular";
import 'file-loader?name=[name].[ext]&outputPath=ngapp/person/partials/!./partials/template.html';

var complexModule = ng.module('ngPerson', []);

export { complexModule };