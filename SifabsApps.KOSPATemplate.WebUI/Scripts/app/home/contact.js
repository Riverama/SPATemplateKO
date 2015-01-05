define('contact',["knockout", "text!/Home/Contact"], function (ko, template) {

    function pageViewModel(params) {
        this.message = "Contact Page";
    }

    return { viewModel: pageViewModel, template: template };

});
