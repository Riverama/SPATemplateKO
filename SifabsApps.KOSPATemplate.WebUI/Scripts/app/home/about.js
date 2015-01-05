define('about',["knockout", "text!/Home/About"], function (ko, template) {

    function pageViewModel(params) {
        this.message = "About Page";
    }

    return { viewModel: pageViewModel, template: template };

});
