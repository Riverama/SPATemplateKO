// require.js looks for the following global when initializing
var require = {
    baseUrl: ".",
    paths: {
        "bootstrap":            "/Scripts/lib/bootstrap.min",
        "crossroads":           "/Scripts/lib/crossroads.min",
        "hasher":               "/Scripts/lib/hasher.min",
        "jquery":               "/Scripts/lib/jquery-1.10.2",
        "knockout":             "/Scripts/lib/knockout-3.2.0",
        "knockout-projections": "/Scripts/lib/knockout-projections",
        "signals":              "/Scripts/lib/signals.min",
        "text":                 "/Scripts/lib/text"
    },
    shim: {
        "bootstrap": { deps: ["jquery"] }
    }
};
