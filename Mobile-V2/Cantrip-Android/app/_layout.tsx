import { Stack } from "expo-router";
import { useState, useEffect } from "react";
import { View, Text } from "react-native";
import * as SQLite from "expo-sqlite";

export default function RootLayout() {
  // const db = SQLite.openDatabase(
  //   {
  //     name: "cantrip-android.db",
  //     location: "default",
  //   },
  //   () => {},
  //   (error) => console.log("Error", error)
  // );
  // const placeholder = placeHolderCharacters;
  const [isLoading, setIsLoading] = useState(true);
  // const [characters, setCharacters] = useState([placeholder]);

  // const createTable = () => {
  //   db.transaction((tx) => {
  //     tx.executeSql(
  //       "CREATE TABLE IF NOT EXISTS characters (id INTEGER PRIMARY KEY, name TEXT, characterClass TEXT, level TEXT);"
  //     );
  //   });
  // };

  // const setData = async () => {
  //   try {
  //     await db.transaction(async (tx) => {
  //       await tx.executeSql(
  //         "INSERT INTO characters (name, characterClass, level) VALUES (?,?,?)",
  //         ["Grog", "Barbarian", "20"]
  //       );
  //     });
  //   } catch (error) {
  //     console.log("Error", error);
  //   }
  // };

  // const getData = async () => {
  //   try {
  //     db.transaction(async (tx) => {
  //       tx.executeSql("SELECT * FROM characters", [], (tx, results) => {
  //         const rows = results.rows;
  //         for (let i = 0; i < rows.length; i++) {
  //           setCharacters;
  //           console.log(rows.item(i));
  //         }
  //       });
  //     });
  //   } catch (error) {
  //     console.log("Error", error);
  //   }
  // };

  // useEffect(() => {
  //   createTable();
  //   setData();
  //   getData();
  //   setIsLoading(false);
  // }, []);

  if (isLoading) {
    return (
      <View>
        <Text>Loading characters...</Text>
      </View>
    );
  } else {
    return (
      <Stack>
        <Stack.Screen name="index" />
      </Stack>
    );
  }
}
