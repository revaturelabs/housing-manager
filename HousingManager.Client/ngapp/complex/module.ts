import * as ng from "angular";
import 'file-loader?name=[name].[ext]&outputPath=ngapp/complex/partials/!./partials/template.html';

var complexModule = ng.module('ngComplex', []);

export { complexModule };