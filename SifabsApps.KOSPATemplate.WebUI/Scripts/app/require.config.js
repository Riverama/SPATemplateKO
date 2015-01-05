// new configuration using asp.net bundles
var require = {
    bundles: {
        '/bundles/libs?v=2015': [
            "signals",
            "crossroads",
            "hasher",
            "jquery",
            "knockout",
            "knockout-projections",            
            "text"
        ],
        '/bundles/app?v=2015': [
            'router',
            'startup',
            'default',
            'contact',
            'about'
        ]
    },
    paths: {
        "bootstrap": "/Scripts/lib/bootstrap.min",
    },
    shim: {
        bootstrap: { deps: ["jquery"] }
    }
};

// Old configuration with individual module files
//var require = {
//    baseUrl: ".",
//    paths: {
//        "bootstrap": "/Scripts/lib/bootstrap.min",
//        "crossroads": "/Scripts/lib/crossroads.min",
//        "hasher": "/Scripts/lib/hasher.min",
//        "jquery": "/Scripts/lib/jquery-1.10.2",
//        "knockout": "/Scripts/lib/knockout-3.2.0",
//        "knockout-projections": "/Scripts/lib/knockout-projections",
//        "signals": "/Scripts/lib/signals.min",
//        "text": "/Scripts/lib/text"
//    },
//    shim: {
//        "bootstrap": { deps: ["jquery"] }
//    }
//};
