'use strict';

var app = angular.module('crossOverApp', []);

app.config(['$routeProvider', function ($routeProvider) {
    $routeProvider
     .when('/', { templateUrl: '/angularjs/app/partials/task.html', controller: 'taskController' })
     .when('/products', { templateUrl: '/Scripts/app/templates/listProduct.html', controller: 'listProductController' })
     .when('/detail', { templateUrl: '/Scripts/app/templates/detail.html', controller: 'detailController' })
     .when('/newProduct', { templateUrl: '/Scripts/app/templates/product.html', controller: 'productController' })
     .otherwise({ rediretTo: '/products' });
}]);



var taskState = { Rejected: 'Rejected', Completed: 'Completed', Running: 'Running', Pending: 'Pending', Accepted: 'Accepted' };
