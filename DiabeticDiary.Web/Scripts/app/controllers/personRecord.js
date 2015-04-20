(function () {
    angular.module('ddApp.controllers').controller("PersonRecordController", ["$http", function ($http) {
        var self = this;
        var records = [];

        $http.get("/api/PersonRecord/GetPersonRecordsForDate?personId=1&date=2015-04-18")
            .success(function(data) {
            self.records = data;
        });
    }]);
})();