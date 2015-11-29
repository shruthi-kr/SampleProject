myApp.directive('contentDetails', function () {
    return {
        restrict: 'EA',
        templateUrl: '/contents/templateView?templateName=ContentStatsTemplate',
        scope: {obj: '='}
    };
});
