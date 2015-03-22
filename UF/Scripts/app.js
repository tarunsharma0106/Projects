//  initiate the ng app with two dependenct  

var pageController = angular.module('pageController', ['ngAnimate', 'ngRoute']);
pageController.config(function ($routeProvider, $locationProvider) {

    $routeProvider
 .when('Gators/Index', {

     controller: 'ListController'
 }).

   when('/Gators/Index', {

       controller: 'ListController0'
   });

})

//  page ctrl for the homw page  
pageController.controller('ListController0', ['$scope', '$http', function ($scope, $http) {
    $http.get('~/Scripts/data.json').success(function (data) {
        $scope.pages = data;
        $scope.pageOrder = 'pagename';
    });
}]);

// page ctrl for the sub folder page
pageController.controller('ListController', ['$scope', '$http', function ($scope, $http) {
    $http.get('~/Scripts/data.json').success(function (data) {
        $scope.pages = data;
        $scope.pageOrder = 'pagename';
    });
}]);


/*  var boxitemCtrl = angular.module('boxitemCtrl',['ngAnimate','ngRoute']);
   boxitemCtrl.controller('bctrl',['$scope','$http',function($scope,$http){
    $http.get('js/item.json').success(function(data){
	  $scope.items = data;
	  
	
	});
   
   }]); */



pageController.controller('bctrl', ['$scope', '$http', function ($scope, $http) {
    $http.get('js/item.json').success(function (data) {
        $scope.items = data;

    });
}]);




