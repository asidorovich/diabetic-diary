(function () {
    var app = angular.module('ddApp');

    app.controller("PersonRecordAddController", ["$scope", '$location', "PersonRecord", function ($scope, $location, PersonRecord) {
        $scope.personRecord = new PersonRecord();
        $scope.add = function () {
            $scope.personRecord.$save(function () {
                $location.path('/');
            });
        };
    }]);
})();