var mailListController = mailModule.controller('mailListController', function ($scope, mailListService) {

    mailListService.getMailList().then(function(response) {
        if (response.data.error) {
            return null;
        }
        else {
            $scope.messages = response.data;
        }
    });

    
});