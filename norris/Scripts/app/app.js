var app = angular.module("norrisFacts", ["highcharts-ng"]);
app.controller('FactController', ['$http','$scope', function ($http,$scope) {
    //this.fact =  $http.get('/facts/Getone').success(function (data) { console.log(data) });
    var fact = new Object();
    $http.get('/facts/Getone').success(function (data) {
        fact.Text = data[0].Text;
        fact.Author = data[0].Author;
        fact.Date = data[0].Date;
        fact.Views = data[0].Views;

        $scope.chartConfig = {
            options: {
                chart: {
                    type: 'bar'
                }
            },
            series: [{
                name: 'Views',
                data: [fact.Views]
            }],
            title: {
                text: 'Views'
            },

            subtitle: {
                text: 'Source: Mit Suthar'
            },
            xAxis: {
                categories: ['Views'],
                title: {
                    text: null
                }
            },
            yAxis: {
                min: 0,
                title: {
                    text: 'Views'
                },
                labels: {
                    overflow: 'justify'
                }
            },
            loading: false
        }
    });

    this.fact= fact;
    this.nextFact = function () {
       // console.log("called");
        $http.get('/facts/Getone').success(function (data) {
            fact.Text = data[0].Text;
            fact.Author = data[0].Author;
            fact.Date = data[0].Date;
            fact.Views = data[0].Views;

            $scope.chartConfig = {
                options: {
                    chart: {
                        type: 'bar'
                    }
                },
                series: [{
                    name: 'Views',
                    data: [fact.Views]
                }],
                title: {
                    text: 'Views'
                },

                subtitle: {
                    text: 'Source: Mit Suthar'
                },
                xAxis: {
                    categories: ['Views'],
                    title: {
                        text: null
                    }
                },
                yAxis: {
                    min: 0,
                    title: {
                        text: 'Views'
                    },
                    labels: {
                        overflow: 'justify'
                    }
                },
                loading: false
            }
        });
        //console.log(fact);
        this.fact = fact;


    };



}]);





//var fact = {
//    Text: "testing",
//    Author: "Ja",
//    Date: "06/06/2014"
//};

