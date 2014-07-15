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

app.controller("DiscussionController", ["$http", "$scope", function ($http, $scope) {
    var god = this;
    var discussions = new Array();
    this.selected_discussion = new Object();
    this.flag = true;
        $http.get('/discussions/GetAllDiscussions/').success(function (data) {
            for (var i = 0; i < data.length; i++) {
                var _discussion = new Object();
                _discussion.ID = data[i].ID;
                _discussion.Text = data[i].Text;
                _discussion.Title = data[i].Title;
                _discussion.Author = data[i].Author;
                _discussion.Views = data[i].Views;
                _discussion.Votes = data[i].Votes;
                discussions.push(_discussion);
            }

        })
        god.discussions = discussions;
        this.switch = function () {
            god.flag = true;
        };
        this.getdiscussion = function (id) {
            console.log(id);
            $http.get('/discussions/getdiscussion/' + id).success(function (data) {
            var _discussion = new Object();
            _discussion.ID = data.ID;
            _discussion.Text = data.Text;
            _discussion.Title = data.Title;
            _discussion.Author = data.Author;
            _discussion.Views = data.Views;
            _discussion.Votes = data.Votes;

            //for (var i = 0; i < data.length; i++) {
            //    var _post = new Object();
            //    _post.Text = this.Text;
            //    posts.push(_post);
            //}
            
            god.flag = false;
            god.selected_discussion = _discussion;
        });
    }
}]);





//var fact = {
//    Text: "testing",
//    Author: "Ja",
//    Date: "06/06/2014"
//};

