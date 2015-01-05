define('default', ["knockout", "text!/Home/Default"], function (ko, template) {

    function pageViewModel(params) {
        this.message = "Home Page";
        this.yourEmail = ko.observable("");       
    }

    return { viewModel: pageViewModel, template: template };
});
