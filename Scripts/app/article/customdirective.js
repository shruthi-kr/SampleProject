myApp.directive('articleDetails', function () {
    return {
        restrict: 'EA',
        templateUrl: '/contents/templateView?templateName=ArticleContentTemplate',
        scope: {articleobj: '='}
    };
});
