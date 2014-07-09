var app = angular.module("norrisFacts", []);
app.controller('FactController', ['$http', function ($http) {
    //this.fact =  $http.get('/facts/Getone').success(function (data) { console.log(data) });
    var fact = new Object();
    $http.get('/facts/Getone').success(function (data) {
        fact.Text = data[0].Text;
        fact.Author = data[0].Author;
        fact.Date = data[0].Date;
    });
    this.fact= fact;
    this.nextFact = function () {
       // console.log("called");
        $http.get('/facts/Getone').success(function (data) {
            fact.Text = data[0].Text;
            fact.Author = data[0].Author;
            fact.Date = data[0].Date;
            fact.Views = data[0].Views;
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

