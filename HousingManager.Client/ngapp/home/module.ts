import * as ng from "angular";
import 'file-loader?name=[name].[ext]&outputPath=ngapp/home/partials/!./partials/template.html';
import 'file-loader?name=[name].[ext]&outputPath=ngapp/home/partials/!./partials/createPersonTemplate.html';

var home = ng.module('ngHome', []);

export { home };