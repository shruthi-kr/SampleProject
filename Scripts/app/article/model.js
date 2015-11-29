ArticleModel = (function () {
    var articleModel = function ArticleModel(data) {
        this.Title = data ? data.Title : null;
        this.ContentType = data ? data.Name : null;
        this.ShortDescription = data ? data.ShortDescription : false;
        this.Description = data ? data.Description : null;
        this.SampleCode = data ? data.SampleCode : false;
        this.CreatedOn = data ? data.CreatedOn : false;
    }
    return articleModel;
}());

