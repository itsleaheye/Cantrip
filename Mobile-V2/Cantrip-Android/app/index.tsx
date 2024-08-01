import { Text, View } from "react-native";
import * as SQLite from "expo-sqlite";
import React, { createContext } from "react";
import { CantripDatabase } from "../db/CantripDatabase";
import CharacterList from "../components/CharacterList";

type DatabaseContextProps = {
  db: SQLite.SQLiteDatabase;
  taskDb: CantripDatabase;
  fetchData: React.Dispatch<React.SetStateAction<boolean>>;
  isDataFetched: boolean;
};

export const DatabaseContext = createContext<DatabaseContextProps>(
  {} as DatabaseContextProps
);

export default function Index() {
  return (
    <View>
      <CharacterList />
    </View>
  );
}
