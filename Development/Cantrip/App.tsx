import * as SQLite from "expo-sqlite";
import React from "react";

export function App() {
  const db = SQLite.openDatabaseSync("cantrip.db");
  db.withTransactionSync;
  return (
    <div>
      <h1>Cantrip</h1>
      <p>Cantrip is a collection of useful React hooks and components.</p>
    </div>
  );
}
