import * as ng from "angular";
import 'file-loader?name=[name].[ext]&outputPath=ngapp/signin/partials/!./partials/template.html';

var signinModule = ng.module('ngSignin', []);

export { signinModule };