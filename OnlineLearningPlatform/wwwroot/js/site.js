"use strict";

var connection = new signalR.HubConnectionBuilder()
    .withUrl("/crudHub")
    .build();

connection.on("LoadFAQs", function () {
    window.location.reload()
});

connection.start().catch(function (err) {
    return console.error(err.toString());
});