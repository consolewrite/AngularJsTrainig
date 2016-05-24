var shoppingCartController = demoModule.controller('shoppingCartController', function (ProductListService,$scope) {

    $scope.bill = {total:0, discount:0, subTotal:0};

    $scope.items = [
        { title: "Sample product one", quantity: 1, price: 10 },
        { title: "Sample product two", quantity: 1, price: 10 },
        { title: "Sample product three", quantity: 1, price: 10 }
    ];

    var calculateTotal = function () {
        var totalPrice = 0;
        for (var i = 0; i < $scope.items.length; i++) {
            totalPrice += $scope.items[i].quantity * $scope.items[i].price;
        }
        $scope.bill.total = totalPrice;
        $scope.bill.discount = totalPrice > 100 ? 10 : 0;
        $scope.bill.subTotal = totalPrice - $scope.bill.discount;
    };

    //$scope.subTotal = function () {
    //    return $scope.total() - $scope.bill.discount; //***************
    //}

    //$scope.calculateDiscount = function (newValue, oldValue, scope) {
    //    $scope.bill.discount = newValue > 100 ? 10 : 0;
    //}

    $scope.remove = function (index) {
        $scope.items.splice(index,1);
    };

    $scope.$watch('items', calculateTotal, true);
});