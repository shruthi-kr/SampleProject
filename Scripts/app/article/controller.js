debugger;
myApp.controller("ArticleCtrl", function ($scope, articleService, $attrs) {
    debugger;
    //scope variables
    $scope.articles;
    $scope.contentType = $attrs.model;
    $scope.init = function (contentType) {
        $scope.contentType = contentType;
    };

    //Promise returnedD:\MyProjects\LoginProject\Controllers/AdminController.cs
    articleService.getArticle($scope.contentType).then(function (result) {
        var articlesData = [];
        angular.forEach(result.data, function (value) {
            var articleModel = new ArticleModel();
            articleModel.Title = value.Title;
            articleModel.ContentType = value.ContentType;
            articleModel.ShortDescription = value.ShortDescription;
            articleModel.Description = value.Description;
            articleModel.SampleCode = value.SampleCode;
            articleModel.CreatedOn = value.CreatedOn;

            this.push(articleModel);
        }, articlesData);
        
        $scope.articles = articlesData;
    });
   
});