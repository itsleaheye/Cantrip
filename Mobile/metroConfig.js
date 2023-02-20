"use strict";

const http = require("http");
const Metro = require("metro");

// We first load the config from the file system
Metro.loadConfig().then(async (config) => {
  const metroBundlerServer = await Metro.runMetro(config);

  const httpServer = http.createServer((req, res) => {
    metroBundlerServer.processRequest(req, res, () => {
      // Metro does not know how to handle the request.
    });
  });

  // Guide shows 2 ways: https://facebook.github.io/metro/docs/getting-started/
  // const httpServer = http.createServer(
  //   metroBundlerServer.processRequest.bind(metroBundlerServer)
  // );

  httpServer.listen(8081);
});

const express = require("express");
const app = express();

app.use(metroBundlerServer.processRequest.bind(metroBundlerServer));

app.listen(8081);
