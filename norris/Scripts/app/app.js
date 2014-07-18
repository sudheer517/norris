var app = angular.module("norrisFacts", []);
app.controller('FactController', ['$http', function ($http) {
    //this.fact =  $http.get('/facts/Getone').success(function (data) { console.log(data) });
    var fact = new Object();
    function getfact()
    {
        $http.get('/facts/Getone').success(function (data) {
            fact.ID = data[0].ID;
            fact.Text = data[0].Text;
            fact.Author = data[0].Author;
            fact.Date = data[0].Date;
            fact.UpVote = data[0].UpVote;
            fact.DownVote = data[0].DownVote;
        });
    }
    getfact();
    this.fact= fact;
    this.nextFact = function () {
       // console.log("called");
        getfact();
        //console.log(fact);
        this.fact = fact;
    };

    this.plusvote = function () {
        this.fact.UpVote += 1;
        $http.get('/facts/update_upvote/' + this.fact.ID).success(function (data) {
            console.log(data);
        });
    };
    this.negvote = function () {
        this.fact.DownVote += 1;
        $http.get('/facts/update_downvote/' + this.fact.ID).success(function (data) {
            console.log(data);
        });
    }
}]);





//var fact = {
//    Text: "testing",
//    Author: "Ja",
//    Date: "06/06/2014"
//};

