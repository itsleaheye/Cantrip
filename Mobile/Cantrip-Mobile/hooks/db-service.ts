// https://blog.logrocket.com/using-sqlite-with-react-native/
import { openDatabase } from "/react-native-sqlite-storage";

export const getDBConnection = async () => {
  return openDatabase({ name: "cantrip.db", location: "default" });
};

export const createTable = async (db: SQLiteDatabase) => {
  // create table if not exists
  const query = `CREATE TABLE IF NOT EXISTS ${character}(
        value TEXT NOT NULL
    );`;

  await db.executeSql(query);
};
