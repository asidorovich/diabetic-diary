(function () {
    var app = angular.module('ddApp');

    //angular.module('ddApp.controllers').controller("PersonRecordController", ["$scope", "$http", "PersonRecord", function ($scope, $http, PersonRecord) {
    app.controller("PersonRecordListController", ["$scope", "$http", "PersonRecord", function ($scope, $http, PersonRecord) {
        //var self = $scope;
        //self.records = [];

        $scope.personRecords = PersonRecord.getPersonRecordsForDate({ personId: 1, date: '2015-04-18' });
    }]);
})();