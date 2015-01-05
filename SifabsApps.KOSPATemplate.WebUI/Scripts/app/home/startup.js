define('startup', ['jquery', 'knockout', 'router', 'bootstrap'], function ($, ko, router) {

    // each component corresponds to a page with a view & model
    ko.components.register('main-page', { require: 'default' })
    ko.components.register('about-page', { require: 'about' });
    ko.components.register('contact-page', { require: 'contact' });


    // Start the application. Pass default selected route
    ko.applyBindings({ route: router.currentRoute });

    console.info("app started");
});