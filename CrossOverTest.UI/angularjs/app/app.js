'use strict';

var app = angular.module('crossOverApp', []);

app.config(['$routeProvider', function ($routeProvider) {
    $routeProvider
     .when('/', { templateUrl: '/angularjs/app/partials/task.html', controller: 'taskController' })    
     .otherwise({ rediretTo: '/products' });
}]);



var taskState = { Rejected: 'Rejected', Completed: 'Completed', Running: 'Running', Pending: 'Pending', Accepted: 'Accepted' };
