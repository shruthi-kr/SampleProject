ContentModel = (function () {
    var contentModel = function ContentModel(data) {
        this.Name = data ? data.Name : null;
        this.ImagePath = data ? data.ImagePath : null;
        this.Value = data ? data.Value : false;
        
    }
    return contentModel;
}());

ContentStatsModel = (function () {
    var contentStatsModel = function ContentStatsModel(data) {
        this.Name = data ? data.Name : null;
        this.ImagePath = data ? data.ImagePath : null;
        this.Value = data ? data.Value : false;

    }
    return contentStatsModel;
}());