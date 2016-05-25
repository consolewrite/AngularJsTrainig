var mailModule = angular.module('mailModule', ['ngRoute']);

mailModule.config(['$routeProvider',
  function ($routeProvider) {
      $routeProvider.
        when('/list', {
            templateUrl: 'templates/List.html',
            controller: 'mailListController'
        }).
        when('/detail/:id', {
            templateUrl: 'templates/Detail.html',
            controller: 'mailDetailController'
        }).
        otherwise({
            redirectTo: '/list'
        });
  }]);