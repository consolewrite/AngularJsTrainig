var shoppingCartController = demo.controller('shoppingCartController', function ($scope) {
    $scope.items = [
        { title: "Sample product one", quantity: 1, price: 10 },
        { title: "Sample product two", quantity: 1, price: 10 },
        { title: "Sample product three", quantity: 1, price: 10 }
    ];

    $scope.totalPrice = function () {
        var totalPrice = 0;
        for (var i = 0; i < $scope.items.length; i++) {
            totalPrice += $scope.items[i].quantity * $scope.items[i].price;
        }
        return totalPrice
    };

    $scope.remove = function (index) {
        $scope.items.splice(index,1);
    };
});