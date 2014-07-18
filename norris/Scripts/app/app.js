var app = angular.module("norrisFacts", ["highcharts-ng"]);

angular.module('norrisFacts').directive('ncgRequestVerificationToken', ['$http', function ($http) {
    return function (scope, element, attrs) {
        $http.defaults.headers.common['RequestVerificationToken'] = attrs.ncgRequestVerificationToken || "no request verification token";
    };
}]);

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
    this.formAddPost= new Object();
    var god = this;
    god.posts = new Array();
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

            $http.get('/discussions/getdiscussion/' + id).success(function (data) {
                var _discussion = new Object();
                god.posts = new Array();
            _discussion.ID = data.ID;
            _discussion.Text = data.Text;
            _discussion.Title = data.Title;
            _discussion.Author = data.Author;
            _discussion.Views = data.Views;
            _discussion.Votes = data.Votes;
       
            god.selected_discussion = _discussion;
            $http.get('/discussionposts/GetPosts/' + id).success(function (data) {
                console.log(id);
                for (var i = 0; i < data.length; i++) {
                    var _post = new Object();
                    //_post.ID = data.ID;
                    _post.Text = data[i].Text;
                    _post.Author = data[i].Author;
                    god.posts.push(_post);
                }
            });
         console.log(god.posts)
                god.flag = false;
            });

        }
        this.addpost = function () {
            var pushdata = { DiscussionID: String(god.selected_discussion.ID), Text: god.formAddPost.Text, Author: god.formAddPost.Author, Votes: 0, Date: "01/01/2014"};
            $http({ method: "POST", url: '/DiscussionPosts/Create', data: pushdata, headers: { '__RequestVerificationToken': $scope.antiForgeryToken, 'RequestVerificationToken': $scope.antiForgeryToken } }).success(function (data) {
                god.posts.push(pushdata); 
                god.formAddPost.Text = "";
                god.formAddPost.Author = "";
                console.log(god.posts);
            });
        };
}]);


