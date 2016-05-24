demoModule.factory('ProductListService', function () {

    var items = {};

    items.query = function () {
        return
        [
            { title: "Sample product one", description: "Sample desc one", quantity: 1, price: 10 },
            { title: "Sample product two", description: "Sample desc two", quantity: 1, price: 10 },
            { title: "Sample product three", description: "Sample desc three", quantity: 1, price: 10 }
        ]
    };

    return items;
});