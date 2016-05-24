var messages = [
    {
        id : 0,
        sender: 'sender0@sender0.com',
        subject: 'Test subject from sender 0',
        date: '24.05.2016',
        recipients: ['rec0@rec0.com'],
        message: 'This is message from sender0 which includes lorem ipsum bla bla text'
    },
    {
        id: 1,
        sender: 'sender1@sender1.com',
        subject: 'Test subject from sender 1',
        date: '24.05.2016',
        recipients: ['rec1@rec1.com'],
        message: 'This is message from sender1 which includes lorem ipsum bla bla text'
    },
    {
        id: 2,
        sender: 'sender2@sender2.com',
        subject: 'Test subject from sender 2',
        date: '24.05.2016',
        recipients: ['rec2@rec2.com'],
        message: 'This is message from sender2 which includes lorem ipsum bla bla text'
    },
];

var mailListController = mailModule.controller('mailListController', function ($scope) {
    $scope.messages = messages;
});

var mailDetailController = mailModule.controller('mailDetailController', function ($scope, $routeParams) {
    $scope.message = messages[$routeParams.id];
});