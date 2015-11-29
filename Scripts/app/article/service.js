myApp.service("articleService", function ($http) {
    debugger;
    this.getArticle = function (contentType) {
        var promise = $http.get('/api/content/' + contentType).
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