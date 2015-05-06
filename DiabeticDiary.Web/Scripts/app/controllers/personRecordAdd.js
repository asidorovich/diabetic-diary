(function () {
    var app = angular.module('ddApp');

    app.controller("PersonRecordAddController", ["$scope", '$location', "PersonRecord", function ($scope, $location, PersonRecord) {

        $scope.personRecord = new PersonRecord();

        $scope.personRecord.PersonId = 1;

        $scope.personRecord.RecordTime = new Date();
        
        $scope.add = function () {
            $scope.personRecord.$save(function () {
                $location.path('/');
            });
        };
    }]);
})();