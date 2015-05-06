(function() {
    var app = angular.module("ddApp", ["ngRoute", 'ui.bootstrap', "personRecordServices"]);

    //angular.module("ddApp.controllers", []);

    app.config([
        '$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
            $routeProvider
                .when('/', {
                    templateUrl: '/Home/PersonRecordGrid',
                    controller: 'PersonRecordListController'
                })
                .when('/pr/add', {
                    templateUrl: '/Home/PersonRecordAdd',
                    controller: 'PersonRecordAddController'
                })
                .otherwise({ redirectTo: '/' });

            $locationProvider.html5Mode(true);
        }
    ]);

    app.controller("UserController", function() {
        
    });
})();