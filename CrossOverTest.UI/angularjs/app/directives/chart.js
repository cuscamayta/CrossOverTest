app.directive('chart', function () {
    return {
        restrict: 'A',
        replace: false,
        scope: {
            model: '='
        },
        link: function (scope, element, attr) {

            createChart();

            function createChart() {         
                $(element).highcharts({
                    chart: {
                        margin: [0, 0, 0, 0],
                        spacingTop: 0,
                        spacingBottom: 0,
                        spacingLeft: 0,
                        spacingRight: 0
                    },
                    credits: {
                        enabled: false
                    },
                    colors: ['#EB7D3B', '#72AC4D'],
                    title: {
                        text: null
                    },
                    plotOptions: {
                        pie: {
                            size: '100%',
                            dataLabels: {
                                enabled: true,
                                distance: -15,
                                formatter: function () {
                                    return Math.round(this.percentage);
                                }
                            }
                        }
                    },
                    yAxis: {min: 0, max: 5000},
                    tooltip: {
                        pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>',
                        style: { fontSize: '5pt' }
                    },
                    exporting: {
                        enabled: false
                    },
                    credits: {
                        enabled: false
                    },
                    series: [{
                        type: 'pie',
                        name: "Unit Test",
                        data: scope.model
                    }]
                });
            }

        }
    }
});