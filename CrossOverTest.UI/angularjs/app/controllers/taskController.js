app.controller('taskController', function ($scope, taskService) {

    init();

    function init() {
        getTasks();

        $('#accordion-task').on('shown.bs.collapse', function (e) {
            $(e.target).parent().find('.icon-state-container').fadeOut('slow');
            $(e.target).find('.task-detail').slideDown('slow');
        });

        $('#accordion-task').on('hidden.bs.collapse', function (e) {
            $(e.target).parent().find('.icon-state-container').fadeIn('slow');
            $(e.target).find('.task-detail').slideUp('slow');
        });
    }


    $scope.createLinkToInfo = function (task, index) {
        return task.State == 'Pending' || task.State == 'Running' ? '' : '#collapse'.concat(index);
    }

    function getTasks() {
        var response = taskService.getTasks();
        response.then(function (data) {
            $scope.tasks = data;
        });
    }


    $scope.showModalInfo = function (task, module) {
        if (module == 'test')

            $('#modal-info-test').modal('show');
        else
            $('#modal-info-change').modal('show');

    }


    $scope.showmodaldeploy = function () {

        $('#modal-deploy').modal('show');
    }


});