app.service('taskService', function ($http, $q) {

    this.getTasks = function () {
        var d = $q.defer();
        $http.get('/Task/GetTasks').success(function (data) {
            d.resolve(data);
        });
        return d.promise;

    };
});

