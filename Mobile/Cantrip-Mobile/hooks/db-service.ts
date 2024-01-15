// // https://blog.logrocket.com/using-sqlite-with-react-native/
//https://docs.expo.dev/versions/latest/sdk/sqlite/ | Android Expo SQLite
import { enablePromise, openDatabase } from "react-native-sqlite-storage";

enablePromise(true);

export const connectToDatabase = async () => {
  return openDatabase(
    { name: "cantrip.db", location: "default" },
    () => {},
    (error) => {
      console.error(error);
      throw Error("Could not connect to database");
    }
  );
};

// export const createCharacterTable =
//   "create table if not exists Characters (id INTEGER PRIMARY KEY AUTOINCREMENT, armor INTEGER, avatar TEXT, phoneNumber text);";
//https://docs.expo.dev/versions/latest/sdk/sqlite/ | Android Expo SQLite
