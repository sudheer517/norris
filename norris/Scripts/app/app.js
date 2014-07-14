var app = angular.module("norrisFacts", []);
app.controller('FactController', ['$http', function ($http) {
    //this.fact =  $http.get('/facts/Getone').success(function (data) { console.log(data) });
    var mycontroller = this;
    var fact = new Object();
    mycontroller.commentText = "";
    $http.get('/facts/Getone').success(function (data) {
        var comments = [];
        fact.Text = data[0].Text;
        fact.Author = data[0].Author;
        fact.Date = data[0].Date;
        fact.id = data[0].ID;
        mycontroller.fact = fact;
        var url = '/comments/getallbyfactid?factid=' + String(mycontroller.fact.id);
        $http.get(url).success(function (data) {
            for (var i = 0; i < data.length; i++) {
                var _comment = new Object();
                _comment.Text = data[i].Text
                _comment.USER_EMAIL = data[i].USER_EMAIL;
                _comment.CID = data[i].ID;
                _comment.Date = data[i].Date;
                comments.push(_comment);
            }
            mycontroller.comments = comments;
        });
    });

    this.addnew = function () {
        var url = '/comments/addnew?commentText=' + String(mycontroller.commentText) + '&factId=' + mycontroller.fact.id;
        $http.get(url).success(function (data) {
            mycontroller.comments.push(data);
            mycontroller.commentText = "";
        });
    };
    this.nextFact = function () {
        mycontroller.commentText = "";
       // console.log("called");
        $http.get('/facts/Getone').success(function (data) {
            fact.Text = data[0].Text;
            fact.Author = data[0].Author;
            fact.Date = data[0].Date;
            fact.id = data[0].ID;
            //console.log(fact);
            mycontroller.fact = fact;
            console.log(mycontroller.fact.id);
            var url = '/comments/getallbyfactid?factid=' + String(mycontroller.fact.id);
            var new_comments = [];
            $http.get(url).success(function (data) {
                console.log(data);
                for (var i = 0; i < data.length; i++) {
                    var _comment = new Object();
                    _comment.Text = data[i].Text
                    _comment.USER_EMAIL = data[i].USER_EMAIL;
                    _comment.CID = data[i].ID;
                    _comment.Date = data[i].Date;
                    new_comments.push(_comment);
                }
                console.log(new_comments);
                mycontroller.comments = new_comments;
            });
        });
       
    };
}]);





//var fact = {
//    Text: "testing",
//    Author: "Ja",
//    Date: "06/06/2014"
//};

