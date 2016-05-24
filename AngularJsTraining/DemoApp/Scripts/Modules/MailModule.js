var mailModule = angular.module('mailModule', ['ngRoute']);

//CONFIG
mailModule.config(function ($routeProvider) {
    $routeProvider.when('/list', {
        controller: mailListController,
        tempalteUrl: '/Templates/List.html'
    }).when('/detail/:id', {
        controller: mailDetailController,
        templateUrl: '/Templates/Detail.html'
    }).otherwise({
        redirectTo: '/list'
    });
});

mailModule.run([
  '$rootScope',
  function ($rootScope) {
      // see what's going on when the route tries to change
      $rootScope.$on('$routeChangeStart', function (event, next, current) {
          //var currentPath = current.route.originalPath;
          //var nextPath = next.originalPath;

          //console.log('Starting to leave %s to go to %s', currentPath, nextPath);
      });
  }
]);

