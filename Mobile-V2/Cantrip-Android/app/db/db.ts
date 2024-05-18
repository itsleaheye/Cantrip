import {
  SQLiteDatabase,
  enablePromise,
  openDatabase,
} from "react-native-sqlite-storage";
import { characterCreateQuery } from "./queries/characterQuery";
import { characterClassesCreateQuery } from "./queries/characterClassesQuery";
import { abilitiesCreateQuery } from "./queries/abilitiesQuery";
import { racesCreateQuery } from "./queries/racesQuery";
import { backgroundsCreateQuery } from "./queries/backgroundQuery";
import { languagesCreateQuery } from "./queries/languagesQuery";
import { itemTypesCreateQuery, itemsCreateQuery } from "./queries/itemsQuery";
import { spellsCreateQuery } from "./queries/spellsQuery";
import { skillsCreateQuery } from "./queries/skillsQuery";

// Enable promise for SQLite
enablePromise(true);

export const connectToDatabase = async () => {
  return openDatabase(
    { name: "cantrip.db", location: "default" },
    () => {},
    (error: any) => {
      console.error(error);
      throw Error("Could not connect to database");
    }
  );
};

export const createTables = async (db: SQLiteDatabase) => {
  try {
    await db.executeSql(abilitiesCreateQuery);
    await db.executeSql(languagesCreateQuery);
    await db.executeSql(backgroundsCreateQuery);
    await db.executeSql(spellsCreateQuery);
    await db.executeSql(itemTypesCreateQuery);
    await db.executeSql(itemsCreateQuery);
    await db.executeSql(skillsCreateQuery);
    await db.executeSql(racesCreateQuery);
    await db.executeSql(characterClassesCreateQuery);
    await db.executeSql(characterCreateQuery);
  } catch (error) {
    console.error(error);
    throw Error(`Failed to create tables`);
  }
};