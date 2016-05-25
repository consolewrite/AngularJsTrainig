var demoController = demoModule.controller('demoController', function ($scope) {
    $scope.schoolName = "şükrü şankaya anatolian high school";

    $scope.message = { text: 'nothing clicked yet' };
    $scope.clickUnfocused = function () {
        $scope.message.text = 'unfocused button clicked';
    };
    $scope.clickFocused = function () {
        $scope.message.text = 'focus button clicked';
    };
});

