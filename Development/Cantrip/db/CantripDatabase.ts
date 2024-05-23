import * as SQLite from "expo-sqlite";
import { characterCreateQuery } from "./queries/characterQuery";

export function initializeDatabase() {
  const db = SQLite.openDatabaseSync("cantrip.db");
  if (!db) {
    throw new Error("Database failed to initialize");
  }

  // Test DB
  db.withTransactionSync(async () => {
    await db.execSync(
      "CREATE TABLE IF NOT EXISTS charactersTest (id INTEGER PRIMARY KEY AUTOINCREMENT, name TEXT, characterClass TEXT, level INTEGER)"
    );
  });

  // Initialize tables
  db.withTransactionSync(async () => {
    await db.execSync(characterCreateQuery);
  });

  return db;
}
