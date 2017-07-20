module.exports = function(config) {
  config.set({
    basePath: '.',

    frameworks: [
      'jasmine'
    ],

    files: [
      'public/**/*.js',
      'test/**/*.spec.js'
    ],

    exclude: [
    ],

    preprocessors: {
    },

    reporters: [
      'progress'
    ],

    port: 9000,

    colors: true,

    logLevel: config.LOG_INFO,

    autoWatch: true,

    browsers: [
      'Firefox'
    ],

    singleRun: false,

    concurrency: Infinity
  });
};
