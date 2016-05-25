mailModule.factory('mailListService', function ($http) {
    var getListUrl = "/data";
    var getListByIdUrl = "/data/getbyid/";
    var mailListService = {
        getMailList: function () {
            return $http.get(getListUrl);
        },
        getMailById: function (id) {
            return $http.get(getListByIdUrl + id);
        }
    }
    return mailListService;
});