myApp.service("contentService", function ($http) {
    debugger;
    this.getContentStats = function () {
        var promise = $http.get('/api/content/stat').
          success(function (data, status) {
              var result = data;
              return result;
          }).
          error(function (data, status) {
              var result = data;
              return result;
          });
        return promise;
    }

});