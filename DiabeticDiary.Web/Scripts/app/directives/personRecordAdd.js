(function () {
    var app = angular.module("person-record-add", ["ddApp.controllers"]);

    app.directive("personRecordAdd", function () {
        return {
            restrict: "E",
            templateUrl: "/Home/PersonRecordAdd",
            controller: "PersonRecordController",
            controllerAs: "personRecord"
        }
    });

})();