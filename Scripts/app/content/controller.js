debugger;
myApp.controller("ContentCtrl", function ($scope, contentService) {
    debugger;
    //scope variables
    $scope.contentStats;

    //Promise returned
    contentService.getContentStats().then(function (result) {
        var contentsData = [];
        angular.forEach(result.data, function (value) {
            var contentStatsModel = new ContentStatsModel();
            contentStatsModel.Name = value.Key;
            contentStatsModel.ImagePath = '~/Content/img/angular' + value.FileName;
            contentStatsModel.Value = value.Value;

            this.push(contentStatsModel);
        }, contentsData);
        
        $scope.contentStats = contentsData;
    });
   
});