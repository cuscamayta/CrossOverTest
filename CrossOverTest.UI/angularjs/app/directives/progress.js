app.directive('progress', function () {
    return {
        restrict: 'E',
        scope: {
            model: '=',
        },
        templateUrl: '/angularjs/app/partials/shared/progress.html',
        link: function (scope, element, attr) {
            scope.currentProgress = 0;

            initProgress();
            function initProgress() {                
                var intervals = Math.round(scope.model.ProcessTime / 60, 0),
                    elementProgress = $(element).find('.icon-state-progress');

                elementProgress.addClass('icon-state-'.concat(scope.model.State.toLocaleLowerCase()));

                for (var i = 0; i < 60; i++) {
                    scope.currentProgress = scope.currentProgress + intervals;
                    elementProgress.animate({ width: scope.currentProgress }, 500);

                    if (scope.currentProgress > 60) break;
                }
            }

        }
    }
});