var mailDetailController = mailModule.controller('mailDetailController', function ($scope, $routeParams, mailListService) {
    mailListService.getMailById(parseInt($routeParams.id)).then(function (response) {
        if (response.data.error) {
            return null;
        }
        else {
            $scope.message = response.data;
        }
    });
});