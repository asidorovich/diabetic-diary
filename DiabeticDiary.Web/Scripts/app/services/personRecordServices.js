(function () {
    'use strict';

    var personRecordServices = angular.module('personRecordServices', ['ngResource']);

    personRecordServices.factory('PersonRecord', ['$resource',
            function ($resource) {
                return $resource('/api/PersonRecord/:id', {}, {
                    getPersonRecordsForDate: { url: "/api/PersonRecord/GetPersonRecordsForDate", method: 'GET', isArray: true}
                });
            }
    ]);
})();